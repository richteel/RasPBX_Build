/* re-enable bootstrap sub-menu */
$(document).ready(function () {
    $('.dropdown-submenu .dropdown-toggle').on("click", function (e) {
        e.stopPropagation();
        e.preventDefault();
        $(this).next('.dropdown-menu').toggle();
    });
});