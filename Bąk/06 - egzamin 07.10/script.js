function count() {
    let type = Number(document.getElementById("type").value);
    let amount = Number(document.getElementById("amount").value);
    let output = document.getElementById("output");
    let lprice = 0;

    if (type == 1) {
        lprice = 4;
        let price = lprice * amount;
        output.innerHTML = "koszt paliwa: " + price + " zł";
    } else if (type == 2) {
        lprice = 3.5;
        let price = lprice * amount;
        output.innerHTML = "koszt paliwa: " + price + " zł";
    } else {
        price = 0;
        output.innerHTML = "koszt paliwa: " + price + " zł";
    }
}

document
    .getElementById("button")
    .addEventListener("click", count);