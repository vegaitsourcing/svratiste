//load dependecies
let gulp = require('gulp'),
	autoprefixer = require('autoprefixer'),
	babel = require('gulp-babel'),
	browserify = require('browserify'),
	iconfont = require('gulp-iconfont'),
	iconfontCss = require('gulp-iconfont-css'),
	notify = require('gulp-notify'),
	plumber = require('gulp-plumber'),
	postcss = require('gulp-postcss'),
	sass = require('gulp-sass'),
	sassLint = require('gulp-sass-lint'),
	size = require('gulp-size'),
	sourcemaps = require('gulp-sourcemaps'),
	svgmin = require('gulp-svgmin'),
	svgSprite = require('gulp-svg-sprite'),
	gutil = require('gulp-util'),
	path = require('path'),
	flexBugsFix = require('postcss-flexbugs-fixes'),
	dust = require('dustjs-linkedin'),
	dustHelpers = require('dustjs-helpers').helpers,
	dusthtml = require('gulp-dust-html'),
	beautify = require('gulp-html-beautify'),
	clean = require('gulp-clean'),
	rename = require('gulp-rename'),
	concat = require('gulp-concat'),
	uglify = require('gulp-uglify-es').default,
	source = require('vinyl-source-stream'),
	buffer = require('vinyl-buffer'),
	pathExists = require('path-exists'),
	runSequence = require('run-sequence'),
	inputPath = __dirname,
	outputPath = inputPath;

//SVG sprite configuration
let projectPath = '/',
	destinationPath = './',
	svgTemplate = "sprite-template.scss",
	spriteName = "_sprite.scss",
	spritePath = {
		newSprite: {
			SRC: 'images/svg/*', //*** svgs used to create sprite
			SVG: 'images/sprite.svg', //*** sprite generated from svgs, it will be placed in - "html\assets\img" called sprite.svg
			FINAL: './css/layout/' //*** scss folder for genetared sprite.scss
		},
		svgTemplate: {
			SRC: 'conf/'
		}
	};

let changeEvent = function (evt) {
	gutil.log('File', gutil.colors.cyan(evt.path.replace(new RegExp('/.*(?=/' + projectPath + ')/'), '')), 'was', gutil.colors.magenta(evt.type));
};

gulp.task('svgSprite', function () {
	return gulp.src(spritePath.newSprite.SRC)
		.pipe(svgSprite({
			shape: {
				spacing: {
					padding: 10
				}
			},
			mode: {
				css: {
					dest: "./",
					layout: "vertical",
					sprite: spritePath.newSprite.SVG,
					bust: false,
					render: {
						scss: {
							dest: spritePath.newSprite.FINAL + spriteName,
							template: spritePath.svgTemplate.SRC + svgTemplate
						}
					}
				}
			},
			variables: {
				mapname: "icons"
			}
		}))
		.pipe(gulp.dest(destinationPath));
});

gulp.task('sprite', ['svgSprite']);

//icon fonts
gulp.task('iconfont', function () {
	return gulp.src(['images/svg/*.svg'])
		.pipe(iconfontCss({
			fontName: 'svgicons',
			cssClass: 'font',
			path: 'conf/icon-font.scss',
			targetPath: inputPath + '/css/layout/_icon-font.scss',
			fontPath: '../../fonts/dist/'
		}))
		.pipe(iconfont({
			fontName: 'svgicons', // required
			prependUnicode: false, // recommended option
			formats: ['ttf', 'woff', 'woff2'], // default, 'woff2' and 'svg' are available
			normalize: true,
			centerHorizontally: true
		}))
		.on('glyphs', function (glyphs, options) {
			// CSS templating, e.g.
			console.log(glyphs, options);
		})
		.pipe(gulp.dest(outputPath + '/fonts/dist/'));
});

//error notification settings for plumber
let plumberErrorHandler = {
	errorHandler: notify.onError({
		title: 'There was some Error, I think...',
		message: "Error message: <%= error.message %>"
	})
};

//SVG optimization
gulp.task('svgomg', function () {
	return gulp.src('images/svg/*.svg')
		.pipe(svgmin({
			plugins: [{
					removeTitle: true
				},
				{
					removeRasterImages: true
				},
				{
					sortAttrs: true
				}
				//{ removeStyleElement: true }
			]
		}))
		.pipe(gulp.dest('images/svg'));
	//.pipe(notify(notifySVGOMG));
});

//Templating helpers
dustHelpers.defaults = function (chunk, context, bodies, params) {
	for (let key in params) {
		context.global[key] = params[key];
	}
	return chunk;
};

//HTML
gulp.task('html-clean', function () {
	return gulp.src([
			outputPath + './*.html'
		])
		.pipe(clean());
});

gulp.task('html-prod', ['html-clean'], function () {

	pathExists('./_templates/').then(exists => {
		return gulp.src([
				'./_templates/pages/**/*.html'
			])
			.pipe(dusthtml({
				basePath: '_templates',
				data: {
					"env": "prod"
				},
				whitespace: true,
				defaultExt: '.html',
				config: {
					cache: false
				}
			}))
			.pipe(beautify({
				indent_char: '',
				indent_size: 4,
				"indent_with_tabs": true
			}))
			.pipe(gulp.dest(outputPath));
	});
});

gulp.task('html-dev', function () {

	pathExists('./_templates/').then(exists => {
		return gulp.src([
				'./_templates/pages/**/*.html'
			])
			.pipe(dusthtml({
				basePath: '_templates',
				data: {
					"env": "dev"
				},
				whitespace: true,
				defaultExt: '.html',
				config: {
					cache: false
				}
			}))
			.pipe(beautify({
				indent_char: '',
				indent_size: 4,
				"indent_with_tabs": true
			}))
			.pipe(gulp.dest(outputPath));
	});
});

//styles
gulp.task('styles', function () {
	let processors = [
		autoprefixer({
			browsers: ['last 2 versions', 'ios >= 8']
		}),
		flexBugsFix
	];
	return gulp.src(['css/**/*.scss'])
		.pipe(plumber(plumberErrorHandler))
		.pipe(sourcemaps.init())
		.pipe(sass({
			outputStyle: 'compressed'
		}))
		.pipe(postcss(processors))
		.pipe(rename('style.min.css'))
		.pipe(sourcemaps.write('.'))
		.pipe(gulp.dest(outputPath + '/css/dist'));
});

gulp.task('sasslint', function () {
	return gulp.src('css/**/*.scss')
		.pipe(sassLint({
			config: '.sass-lint.yml'
		}))
		.pipe(sassLint.format())
		.pipe(sassLint.failOnError())
});

//js
let jsDest = outputPath + '/js/dist';

gulp.task('js', function () {
	return browserify('js/default.js').bundle()
		.pipe(source('default.js'))
		.pipe(buffer())
		.pipe(babel({
			presets: ['es2015'],
			compact: false
		}))
		.pipe(gulp.dest(jsDest));
});

gulp.task('js-libs', function () {
	return gulp.src(['js/libs/jquery-3.3.1.min.js', 'js/libs/**/*.js'])
		.pipe(concat('libs.js'))
		.pipe(gulp.dest(jsDest));
});

gulp.task('js-merge', function () {
	return gulp.src([jsDest + '/libs.js', jsDest + '/default.js'])
		.pipe(sourcemaps.init())
		.pipe(plumber())
		.pipe(concat('global.js'))
		.pipe(gulp.dest(jsDest))
		.pipe(uglify())
		.pipe(rename('global.min.js'))
		.pipe(sourcemaps.write('.'))
		.pipe(gulp.dest(jsDest));
});

gulp.task('js-clean', function () {
	return gulp.src([jsDest + '/libs.js', jsDest + '/default.js'], {
			read: false
		})
		.pipe(clean());
});

gulp.task('js-build', function () {
	runSequence('js', 'js-libs', 'js-merge', 'js-clean');
});

//watch
gulp.task('default', ['html-dev', 'styles', 'sasslint', 'js-build'], function () {
	//watch .scss files
	gulp.watch('css/**/*.scss', ['styles', 'sasslint']);

	//watch .js files
	gulp.watch(['js/**/*.js', '!js/dist/*.js'], ['js-build']);

	//watch added or changed svg files to optimize them
	gulp.watch('svg/*.svg', ['svgomg']);

	//watch svg icons and create a sprite
	gulp.watch(spritePath.newSprite.SRC, ['sprite']).on('change', function (evt) {
		changeEvent(evt);
	});

	//html
	gulp.watch(['_templates/**/*.html', '!_templates/*.html'], ['html-dev']);
});

//build
gulp.task('build', ['html-dev', 'sprite', 'iconfont', 'styles', 'js-build']);
gulp.task('build-prod', ['html-prod', 'sprite', 'iconfont', 'styles', 'js-build']);
