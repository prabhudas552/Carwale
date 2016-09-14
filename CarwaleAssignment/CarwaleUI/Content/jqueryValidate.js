// Form Validation
function validateInput() {
    var errMessage = "* required..!";
    if (!$("#firstName").val()) {
        $("#lblFirstName").show().text(errMessage);
        return false;
    }
    else if (!$("#lastName").val()) {
        $("#lblLastName").show().text(errMessage);
        return false;
    }
    else if ($("#month").val() == -1 || $("#day").val() == -1 || $("#year").val() == -1) {
        $("#lblDoB").show().text(errMessage);
        return false;
    }
    else if (!$("input[name=gender]:checked").val()) {
        $("#lblGender").show().text(errMessage);
        return false;
    }
    else {
        return true;
    }
}
$("#firstName").focus(function () {
    $("#lblFirstName").hide();
});
$("#lastName").focus(function () {
    $("#lblLastName").hide();
});
$("#month,#day,#year").focus(function () {
    $("#lblDoB").hide();
});
$("input[name=gender]").focus(function () {
    $("#lblGender").hide();
});

// Slide Down here
$(document).ready(function () {
    $("#quickLink1").click(function () {
        $("#quickLinkContent1").slideToggle("slow");
    });
    $("#quickLink2").click(function () {
        $("#quickLinkContent2").slideToggle("slow");
    });
    $("#quickLink3").click(function () {
        $("#quickLinkContent3").slideToggle("slow");
    });
});