$(document).ready(function () {

    var toggleClass = "shown";

    $(".show").on('click', function () {

        var self = $(this);
        var parent = self.parent();
        $(".foldable-content").slideDown("slow", function () {
            self.hide();
            parent.find(".hide").show();
            parent.toggleClass(toggleClass);
        });
    });

    $(".hide").on('click', function () {

        var self = $(this);
        var parent = self.parent();
        $(".foldable-content").slideUp("slow", function () {
            self.hide();
            parent.find(".show").show();
            parent.toggleClass(toggleClass);
        });
    });

    

});