$(document).ready(function () {
    $("ul.tabs li:first a").addClass("active").show();
        $(".tab_content:first").show();

        $("ul.tabs li").click(function () {
            $("ul.tabs li a").removeClass("active");
            $(this).children('a').addClass("active");
            $(".tab_content").hide();

            var activeTab = $(this).find("a").attr("href");

            $(activeTab).fadeIn();
            return false;
        });
});