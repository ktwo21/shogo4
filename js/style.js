AOS.init();

flatpickr.localize(flatpickr.l10ns.ja);
flatpickr('.selector', {
	minDate: "today",
	mode: "multiple",
	dateFormat: "Y-m-d",
	conjunction: " :: "
});

$(function() {

	//ð
	$(".hamburger-button").click(function() {
		$(".hamburger-button, .hamburger-menu").toggleClass("open");
		$(".white-bg").fadeToggle();
	});
	
	$("a").click(function() {
		$(".hamburger-button, .hamburger-menu").removeClass("open");
		$(".white-bg").fadeOut();
	});
	
	$(".white-bg").click(function() {
		$(".hamburger-button, .hamburger-menu").removeClass("open");
		$(".modal").fadeOut(300);
		$(".white-bg").fadeOut();
		$("body").removeClass("fixed");
	});
	
	
	//ã¢ã¼ãã«
	$("#js-modal-open").click(function() {
		if($(".hamburger-button, .hamburger-menu").hasClass("open")) {
			$(".white-bg").fadeIn();
			$(".modal").fadeToggle(300);
			$("body").toggleClass("fixed");
		} else {
			$(".modal").fadeToggle(300);
			$(".white-bg").fadeToggle();
			$("body").toggleClass("fixed");
		} 

	});
	
	$("#close-button").click(function () {
		$(".modal").fadeOut(300);
		$(".white-bg").fadeOut();
		$("body").removeClass("fixed");
		$(".hamburger-button, .hamburger-menu").removeClass("open");
	});
	
	//ããã²ã¼ã·ã§ã³
	function NavigationList() {
	
		var navigationH = $(".navigation").outerHeight(true);
		var scroll = $(window).scrollTop();
		if(scroll >= navigationH) {
			$(".navigation").addClass("scroll-navigation");
			} else {
			$(".navigation").removeClass("scroll-navigation");
		}
	}
	
	$(window).scroll(function() {
		NavigationList();
	});
	
	
	
	//ã¿ãã¡ãã¥ã¼
  let tabs = $(".list"); // tabã®ã¯ã©ã¹ãå¨ã¦åå¾ããå¤æ°tabsã«éåã§å®ç¾©
  $(".list").on("click", function() { // tabãã¯ãªãã¯ãããã¤ãã³ãçºç«
    $(".focus").removeClass("focus"); // activeã¯ã©ã¹ãæ¶ã
    $(this).addClass("focus"); // ã¯ãªãã¯ããç®æã«activeã¯ã©ã¹ãè¿½å 
    const index = tabs.index(this); // ã¯ãªãã¯ããç®æãã¿ãã®ä½çªç®ãå¤å®ããå®æ°indexã¨ãã¦å®ç¾©
    $(".card-list > .items").removeClass("active").eq(index).addClass("active"); // showã¯ã©ã¹ãæ¶ãã¦ãcontentã¯ã©ã¹ã®indexçªç®ã«showã¯ã©ã¹ãè¿½å 
  })
  
   // ã¹ã ã¼ã¹ã¹ã¯ã­ã¼ã«
  $('a[href^="#"]').click(function(){
    let speed = 1000;
    let href= $(this).attr("href");
    let target = $(href == "#" || href == "" ? 'html' : href);
    let position = target.offset().top;
    $("html, body").animate({scrollTop:position}, speed, "swing");
    return false;
  });
});
