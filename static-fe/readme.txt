//----------  CHANGELOG 2018-06-12
//------------------------------------------------------------------------------

breakpoints.scss - added media only screen to prevent triggering on print mode
style.scss - print.scss movde to be the last import
reset.scss - main element is set to be block - due to IE rendering issue
helpers.scss - added cover-img class, for cover images. There is an example on the homepage in starter
helpers.scss - Theming and colors iterator and variables need to be set i variables.scss file
reset.scss - removed shadows from input field (they appear on iOS by default)
iconfont - Font is now compiling to fonts/dist folder
hover only for desktop (not available on touch devices)
gitignore updates
Bootstrap update to 4.1.1.
Slick update to version 1.9.0

//----------  README
//------------------------------------------------------------------------------

NOTE: if you have node.js and gulp installed, skip to step 4.

1. Download and install node.js https://nodejs.org/en/download/
2. Run node.js command prompt
3. Install gulp globally - "npm install gulp -g" and "npm install gulp-cli -g"
4. Next run "npm install" to collect all gulp dependencies
5. To compile styles/svgs/html run "gulp" for development watch, or "gulp build" for a clean build

/***** SVG SPRITE *****/
To compile svg sprite, run "gulp sprite" command.
Do not forget to add your sprite icon to "_icons.scss" file.
In order to show svg sprit icons, all you need to do is add html "<span class="ico ico-heart"></span>"

/***** ICON FONT *****/
Icon font: to generate new icons and create font, run "gulp iconfont" command.
In order to show icons, all you need to do is add html "<span class="icon font-ico-heart"></span>"

/***** package.json *****/
NOTE: if package.json is empty or not updating, run "npm init" command.

/***** Node modules remove *****/
Removing node_modules folder from the project in Windows is almost impossible,
but you can use SHIFT + DELETE in Total Commander.

We would recommend using rimraf plugin. Type "npm install rimraf -g".
Navigate to the project folder, type "rimraf node_modules" to remove node_modules.

/***** Node.js update *****/
1. Uninstall previous version and close all open terminals
2. Install new version
3. Open terminal and type "npm cache clean"
4. Then run "npm install"

NOTE: If you get error message in compiling project with installed node modules, please remove node_modules folder and install dependencies again. Reason is that dependencies are connected to old Node.js instance.

