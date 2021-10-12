AOS.init();

flatpickr.localize(flatpickr.l10ns.ja);
flatpickr('.selector', {
	minDate: "today",
	mode: "multiple",
	dateFormat: "Y-m-d",
	conjunction: " :: "
});

$(function() {

	//🍔
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
	
	
	//モーダル
	$("#js-modal-open").click(function() {
		$(".modal").fadeToggle(300);
		$(".white-bg").fadeToggle();
		$("body").toggleClass("fixed");
	});
	
	$("#close-button").click(function () {
		$(".modal").fadeOut(300);
		$(".white-bg").fadeOut();
		$("body").removeClass("fixed");
	});
	
	//ナビゲーション
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
	
	
	
	//タブメニュー
  let tabs = $(".list"); // tabのクラスを全て取得し、変数tabsに配列で定義
  $(".list").on("click", function() { // tabをクリックしたらイベント発火
    $(".focus").removeClass("focus"); // activeクラスを消す
    $(this).addClass("focus"); // クリックした箇所にactiveクラスを追加
    const index = tabs.index(this); // クリックした箇所がタブの何番目か判定し、定数indexとして定義
    $(".card-list > .items").removeClass("active").eq(index).addClass("active"); // showクラスを消して、contentクラスのindex番目にshowクラスを追加
  })
  
   // スムーススクロール
  $('a[href^="#"]').click(function(){
    let speed = 1000;
    let href= $(this).attr("href");
    let target = $(href == "#" || href == "" ? 'html' : href);
    let position = target.offset().top;
    $("html, body").animate({scrollTop:position}, speed, "swing");
    return false;
  });
});
