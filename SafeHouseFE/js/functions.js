'use strict';

module.exports = {

	isWinScrolling: 0,

	// fill in sections navigation
	sectionNavigation: function() {
		$('section').each(function(){
			var sectionName = $(this).data('section-name');
			var listItem = '<li role="menuitem"><span class="seclink">' + sectionName + '</span></li>';
			$('.nav ul').append(listItem);
			$('.nav ul').find('li').first().addClass('active');
		});
	},

	sectionScrolling: function() {

		setTimeout(function() {
			$('.scroll-section').on('click', function () {
				$('html, body').animate({scrollTop: ($(this).parents('section').next().offset().top - $('.header').outerHeight())}, 600);
			});

			$('.scroll-to-top').on('click', function () {
				$('html, body').animate({scrollTop: 0}, 1000);
			});

			$('.nav li .seclink, .header-menu li a').on('click', function(e) {
				e.preventDefault();
				var link = $(this).parent().index();
				var section = $('.sections section').eq(link);
				var offset = section.offset().top;
				var headerHeight = $('.header').outerHeight();
				this.isWinScrolling = 1;

				$('.nav li, .header-menu li').removeClass('active');
				$(this).parent().addClass('active');
				$('html, body').stop().animate({ scrollTop: offset - headerHeight}, 600, function() {
					this.isWinScrolling = 0;
				});
			});

			$('.header .menu-toggle').on('click', function () {
				$(this).toggleClass('active');
				$('.header .header-menu').stop().slideToggle(300);
			});
		}, 100);

		$(window).on('scroll', function(){
			if(this.isWinScrolling === 1){
				return false;
			} else {
				var link = $('.nav li');
				var offset =  $(this).scrollTop();
				var headerHeight = $('.header').outerHeight();
				var scrollHeight = $(document).height();
				var scrollPosition = $(window).height() + $(window).scrollTop();

				$('.sections section').each(function() {
					var top = $(this).offset().top - headerHeight;

					if (offset >= top){
						link.removeClass('active');
						link.eq($(this).index()).addClass('active');
					}
					if ((scrollHeight - scrollPosition) / scrollHeight === 0) {
						link.removeClass('active');
						link.last().addClass('active');
					}
				});
			}
		});
	},

	initSlider: function() {
		let $slider = $('.slider');
		if ($slider !== undefined && $slider.length) {
			$slider.slick();
		}
	},

	objectFit: function () {
		if ($('img') !== undefined && $('img').length > 0) {
			// IE object fit
			objectFitImages();
		}
	},

	// equal heights
	equalHeights: function(arrayItems, count) {
		if (arrayItems !== undefined && arrayItems.length > 0) {
			arrayItems.height('');

			var maxH = 0;

			if (count) {
				var arrays = [];
				while (arrayItems.length > 0) {
					arrays.push(arrayItems.splice(0, count));
				}

				for (var i = 0; i < arrays.length; i += 1) {
					var data = arrays[i];
					maxH = 0;
					for (var j = 0; j < data.length; j += 1) {
						var currentH = $(data[j]).outerHeight(true);
						if (currentH > maxH) {
							maxH = currentH;
						}
					}

					for (var k = 0; k < data.length; k += 1) {
						$(data[k]).css('height', maxH);
					}
				}
			} else {
				arrayItems.each(function () {
					var currentH2 = $(this).outerHeight(true);
					if (currentH2 > maxH) {
						maxH = currentH2;
					}
				});

				arrayItems.css('height', maxH);
			}
		}
	}
};
