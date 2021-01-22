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

const showoverlay = document.querySelector(".movie_blackbird");
const overlay = document.querySelector("#blackbird");
showoverlay.addEventListener('click', function () {
    overlay.classList.add("show");
});
overlay.addEventListener('click', function () {
    overlay.classList.remove("show");
});

const showoverlay2 = document.querySelector(".movie_nightingale");
const overlay2 = document.querySelector("#nightingale");
showoverlay2.addEventListener('click', function () {
    overlay2.classList.add("show");
});
overlay2.addEventListener('click', function () {
    overlay2.classList.remove("show");
});

const showoverlay3 = document.querySelector("#side_lobster");
const overlay3 = document.querySelector("#lobster");
showoverlay3.addEventListener('click', function () {
    overlay3.classList.add("show");
});
overlay3.addEventListener('click', function () {
    overlay3.classList.remove("show");
});

const showoverlay4 = document.querySelector("#side_arrival");
const overlay4 = document.querySelector("#arrival");
showoverlay4.addEventListener('click', function () {
    overlay4.classList.add("show");
});
overlay4.addEventListener('click', function () {
    overlay4.classList.remove("show");
});