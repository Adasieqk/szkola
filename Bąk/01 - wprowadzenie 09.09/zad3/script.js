let ilosc_gosci = document.querySelector("#iloscgosci");
let poprawiny = document.querySelector("#poprawiny");
let output = document.querySelector("#output");

function wesele() {
    let liczbagosci = ilosc_gosci.value;
    let koszt = "";

    if (poprawiny.checked === true) {
        koszt = liczbagosci * 100 * 1.3;
    }
    else if (poprawiny.checked === false) {
        koszt = liczbagosci * 100;
    }

    output.innerHTML = koszt;
};