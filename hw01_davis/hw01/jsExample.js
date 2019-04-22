function printOrder() {

    var msg = "Order\n-----------------------\n";

    var output = document.getElementById("output");
    var bookList = document.getElementById("books");
    var bookName = document.getElementById("book");
    var bookPrice = document.getElementById("price");
    var radioButtons = document.getElementsByName("customer");
    var dropdownList = document.getElementById("states");
    var rushed = document.getElementById("rushOrder");
    var wrapped = document.getElementById("giftWrapped");
    var ddlCost = parseFloat(dropdownList.options[dropdownList.selectedIndex].value);
    var ddlName = dropdownList.options[dropdownList.selectedIndex].text;

    var discount = 0;
    var total = 0;

    for (i = 0; i < books.length; i++) {
        if (books[i].selected) {
            msg += "$" + parseFloat(books[i].value).toFixed(2) + " - " + books[i].text + "\n";
            total += parseFloat(books[i].value);
        }
    }

    if (bookName.value != "" && bookPrice.value != "") {
        msg += "$" + parseFloat(bookPrice.value).toFixed(2) + " - " + bookName.value + " (User Specified)\n";
        total += parseFloat(bookPrice.value);
    }

    for (i = 0; i < radioButtons.length; i++) {
        if (radioButtons[i].checked) {
            discount = radioButtons[i].value;
            if (discount != 0) {
                msg += "Government Customer";
            }
            else {
                msg += "General Customer";
            }
        }
    }

    if (rushed.checked) {
        msg += "\n$" + parseFloat(rushed.value).toFixed(2) + " - " + "Rush Order";
        total += parseFloat(rushed.value);
    }

    if (wrapped.checked) {
        msg += "\n$" + parseFloat(wrapped.value).toFixed(2) + " - " + "Gift Wrapped";
        total += parseFloat(wrapped.value);
    }

    msg += "\n$" + ddlCost.toFixed(2) + " - Ship to " + ddlName;
    total += ddlCost;

    if (discount != 0) {
        msg += "\n-----------------------\n";
        msg += "SubTotal: " + total.toFixed(2) + "\n";
        discount = total * 0.1;
        msg += "Discount (10%): $" + discount.toFixed(2);
        total -= discount;
        msg += "\nTotal: $" + total.toFixed(2);
    }

    else {
        msg += "\n-----------------------\n";
        msg += "Total: $" + total.toFixed(2);
    }

    output.value = msg;
}