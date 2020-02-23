/*
	Massively by HTML5 UP
	html5up.net | @ajlkn
	Free for personal and commercial use under the CCA 3.0 license (html5up.net/license)
*/

(function($) {

	var	$window = $(window),
		$body = $('body'),
		$wrapper = $('#wrapper'),
		$header = $('#header'),
		$nav = $('#nav'),
		$main = $('#main'),
		$navPanelToggle, $navPanel, $navPanelInner;

	// Breakpoints.
		breakpoints({
			default:   ['1681px',   null       ],
			xlarge:    ['1281px',   '1680px'   ],
			large:     ['981px',    '1280px'   ],
			medium:    ['737px',    '980px'    ],
			small:     ['481px',    '736px'    ],
			xsmall:    ['361px',    '480px'    ],
			xxsmall:   [null,       '360px'    ]
		});

	/**
	 * Applies parallax scrolling to an element's background image.
	 * @return {jQuery} jQuery object.
	 */
	$.fn._parallax = function(intensity) {

		var	$window = $(window),
			$this = $(this);

		if (this.length == 0 || intensity === 0)
			return $this;

		if (this.length > 1) {

			for (var i=0; i < this.length; i++)
				$(this[i])._parallax(intensity);

			return $this;

		}

		if (!intensity)
			intensity = 0.25;

		$this.each(function() {

			var $t = $(this),
				$bg = $('<div class="bg"></div>').appendTo($t),
				on, off;

			on = function() {

				$bg
					.removeClass('fixed')
					.css('transform', 'matrix(1,0,0,1,0,0)');

				$window
					.on('scroll._parallax', function() {

						var pos = parseInt($window.scrollTop()) - parseInt($t.position().top);

						$bg.css('transform', 'matrix(1,0,0,1,0,' + (pos * intensity) + ')');

					});

			};

			off = function() {

				$bg
					.addClass('fixed')
					.css('transform', 'none');

				$window
					.off('scroll._parallax');

			};

			// Disable parallax on ..
				if (browser.name == 'ie'			// IE
				||	browser.name == 'edge'			// Edge
				||	window.devicePixelRatio > 1		// Retina/HiDPI (= poor performance)
				||	browser.mobile)					// Mobile devices
					off();

			// Enable everywhere else.
				else {

					breakpoints.on('>large', on);
					breakpoints.on('<=large', off);

				}

		});

		$window
			.off('load._parallax resize._parallax')
			.on('load._parallax resize._parallax', function() {
				$window.trigger('scroll');
			});

		return $(this);

	};

	// Play initial animations on page load.
		$window.on('load', function() {
			window.setTimeout(function() {
				$body.removeClass('is-preload');
			}, 100);
		});

	// Scrolly.
		$('.scrolly').scrolly();

	// Background.
		$wrapper._parallax(0.925);

	// Nav Panel.

		// Toggle.
			$navPanelToggle = $(
				'<a href="#navPanel" id="navPanelToggle">Menu</a>'
			)
				.appendTo($wrapper);

			// Change toggle styling once we've scrolled past the header.
				$header.scrollex({
					bottom: '5vh',
					enter: function() {
						$navPanelToggle.removeClass('alt');
					},
					leave: function() {
						$navPanelToggle.addClass('alt');
					}
				});

		// Panel.
			$navPanel = $(
				'<div id="navPanel">' +
					'<nav>' +
					'</nav>' +
					'<a href="#navPanel" class="close"></a>' +
				'</div>'
			)
				.appendTo($body)
				.panel({
					delay: 500,
					hideOnClick: true,
					hideOnSwipe: true,
					resetScroll: true,
					resetForms: true,
					side: 'right',
					target: $body,
					visibleClass: 'is-navPanel-visible'
				});

			// Get inner.
				$navPanelInner = $navPanel.children('nav');

			// Move nav content on breakpoint change.
				var $navContent = $nav.children();

				breakpoints.on('>medium', function() {

					// NavPanel -> Nav.
						$navContent.appendTo($nav);

					// Flip icon classes.
						$nav.find('.icons, .icon')
							.removeClass('alt');

				});

				breakpoints.on('<=medium', function() {

					// Nav -> NavPanel.
						$navContent.appendTo($navPanelInner);

					// Flip icon classes.
						$navPanelInner.find('.icons, .icon')
							.addClass('alt');

				});

			// Hack: Disable transitions on WP.
				if (browser.os == 'wp'
				&&	browser.osVersion < 10)
					$navPanel
						.css('transition', 'none');

	// Intro.
		var $intro = $('#intro');

		if ($intro.length > 0) {

			// Hack: Fix flex min-height on IE.
				if (browser.name == 'ie') {
					$window.on('resize.ie-intro-fix', function() {

						var h = $intro.height();

						if (h > $window.height())
							$intro.css('height', 'auto');
						else
							$intro.css('height', h);

					}).trigger('resize.ie-intro-fix');
				}

			// Hide intro on scroll (> small).
				breakpoints.on('>small', function() {

					$main.unscrollex();

					$main.scrollex({
						mode: 'bottom',
						top: '25vh',
						bottom: '-50vh',
						enter: function() {
							$intro.addClass('hidden');
						},
						leave: function() {
							$intro.removeClass('hidden');
						}
					});

				});

			// Hide intro on scroll (<= small).
				breakpoints.on('<=small', function() {

					$main.unscrollex();

					$main.scrollex({
						mode: 'middle',
						top: '15vh',
						bottom: '-15vh',
						enter: function() {
							$intro.addClass('hidden');
						},
						leave: function() {
							$intro.removeClass('hidden');
						}
					});

			});

		}

        

})(jQuery);

//Manual date switcher for: DraftCreate.vue
function startDateSwitch() {  
	//Get todays date
	var today = new Date();
	var dd = today.getDate();
	var mm = today.getMonth()+1; //January is 0!
	var yyyy = today.getFullYear();
 	if(dd<10){
        dd='0'+dd
    } 
    if(mm<10){
        mm='0'+mm
    } 

	today = yyyy+'-'+mm+'-'+dd;
	document.getElementById("tpManualDate").setAttribute("min", today);

	if(document.getElementById('rdoDraftStartMan').checked == true) { 
		document.getElementById("lblManDate").style.display = "block";
		document.getElementById("tpManualDate").style.display = "block";
	} 
	else if(document.getElementById('rdoDraftStartAuto').checked == true) { 
		document.getElementById("lblManDate").style.display = "none";
		document.getElementById("tpManualDate").style.display = "none";
	}
}

// Toggle draft settings display
function draftSettingsSwitch() {  
	if (document.getElementById("draftSettingsArrowToggle").style.width != "100%") {
		//Collapsed
		document.getElementById("preGrid").style.gridTemplateColumns = "98.4% 1.6%";
		document.getElementById("draftSettingsArrowToggle").style.width = "100%";
		document.getElementById("btnStartDraft").style.display = "none";
		document.getElementById("open-button").style.right = "3.5%";
		document.getElementById("chatForm").style.right = "3.5%";
		document.getElementById("draftSettingsArrow").style.classList.remove("fa-angle-left");
		document.getElementById("draftSettingsArrow").style.classList.add("fa-angle-right");
		
	}
	else  {
		//Open
		document.getElementById("preGrid").style.gridTemplateColumns = "80% 20%";
		document.getElementById("draftSettingsArrowToggle").style.width = "8%";
		document.getElementById("btnStartDraft").style.display = "block";
		document.getElementById("open-button").style.right = "22%";
		document.getElementById("chatForm").style.right = "22%";
		document.getElementById("draftSettingsArrow").style.classList.add("fa-angle-left");
		document.getElementById("draftSettingsArrow").style.classList.remove("fa-angle-right");
		
	}
		
}

// Show team area
function teamSwitch() {
	var element2 = document.getElementById("btnTeamSwitch");
	var element = document.getElementById("btnPlayerSwitch");
	element.classList.add("primary");
	element2.classList.remove("primary");

	var teamArea = document.getElementById("teamArea");
	var playerArea = document.getElementById("playersArea");
	teamArea.style.display = "block";
	playerArea.style.display = "none";
}
// show player area
function playerSwitch() {
	var element2 = document.getElementById("btnPlayerSwitch");
	var element = document.getElementById("btnTeamSwitch");
	element.classList.add("primary");
	element2.classList.remove("primary");

	var teamArea = document.getElementById("teamArea");
	var playerArea = document.getElementById("playersArea");
	teamArea.style.display = "none";
	playerArea.style.display = "block";
}

// chat window open-close
function openForm() {
	if (document.getElementById("chatForm").style.display == "block")
		document.getElementById("chatForm").style.display = "none";
	else
		document.getElementById("chatForm").style.display = "block";
}

