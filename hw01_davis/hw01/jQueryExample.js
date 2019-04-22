$(document).ready(function () {
    $("#printOrder").click(function () {

        var msg = "Order\n-----------------------\n";

        var total = 0;
        var discount = 0;

        $("#books option:selected").each(function () {
            msg += "$" + parseFloat($(this).val()).toFixed(2) + " - " + $(this).text() + "\n";
            total += parseFloat($(this).val());
        });

        if ($("#book").val() != "" && $("#price").val() != "") {
            msg += "$" + parseFloat($("#price").val()).toFixed(2) + " - " + $("#book").val() + " (User Specified)\n";
            total += parseFloat($("#price").val());
        }

        discount = parseFloat($("input[name='customer']:checked").val()).toFixed(2);
        if (discount != 0) {
            msg += "Government Cusomter\n";
        }
        else {
            msg += "General Customer\n";
        }

        $("input[name='checkbox']:checked").each(function () {
            var type;
            if (parseInt($(this).val()) == 10) {
                type = "Rush Order"
            }
            else {
                type = "Gift Wrapped"
            }
            msg += "$" + parseFloat($(this).val()).toFixed(2) + " - " + type + "\n";
            total += parseFloat($(this).val());
        });

        msg += "$" + parseFloat($("#states option:selected").val()).toFixed(2) + " - Shipped to " + $("#states option:selected").text() + "\n";
        total += parseFloat($("#states option:selected").val());

        msg += "---------------------------\n";

        if (discount != 0) {
            msg += "SubTotal: $" + total.toFixed(2) + "\n";
            discount = total * 0.1;
            msg += "Discount (10%): $" + discount.toFixed(2) + "\n";
            total -= discount;
            msg += "Total: $" + total.toFixed(2);
        }
        else {
            msg += "Total: $" + total.toFixed(2);
        }

        $("#output").val(msg);
    });
});