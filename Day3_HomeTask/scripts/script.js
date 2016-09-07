$.fn.exists = function () {
    return this.length !== 0;
}

$("#yes").on("click", function(event) {
    if ($(".darkSide").exists()) {
        event.preventDefault();
        $(".footer").html("<h5>LOL. There is no way out! PS. Your HR department has been contacted</h5>");
    }
});

$("#no").on("click", function () {
    $(".footer").remove();
});