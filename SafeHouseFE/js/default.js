'use strict';

let functions = require('./functions');

let app = {
	init: function () {
		// call your functions here
		// functions.objectFit();


		if (('ontouchstart' in window || navigator.msMaxTouchPoints > 0) && window.matchMedia('screen and (max-width: 1024px)').matches) {
			$('html').addClass('touch');
		} else {
			$('html').addClass('no-touch');
		}

	},
	winLoad: function () {
		// call functions that are needed for window load
		// functions.sectionScrolling();
	},
	winResize: function () {
		// call functions that are needed on window resize
		console.log('window resized');
	}
};

$(function() {
	app.init();
});

$(window).on('load', function() {
	app.winLoad();
});

$(window).on('resize', function() {
	app.winResize();
});
