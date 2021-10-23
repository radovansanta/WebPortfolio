
function renderjQueryComponents() {
    $(document).ready(function () {
        $(window).scroll(function () {
            var scroll = $(window).scrollTop();
            if (scroll > 90) {
                $(".navcolor").css("background", "rgba(255, 255, 255, 0.4)");
            } else {
                $(".navcolor").css("background", "#091634");
            }
        })
    })
}