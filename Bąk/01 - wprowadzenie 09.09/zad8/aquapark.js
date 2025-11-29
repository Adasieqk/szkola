
let duza_rodzina = document.getElementById("duza_rodzina");
let wypisz = document.getElementById("wypisz");
let oblicz = document.getElementById("oblicz");
let wynik;
let bilet;
let bilet_ulgowy;
let darmowe;
let znizka;
function aquapark() {
    let ilosc_bilet_ulgowy = parseInt(document.getElementById("ulgowe").value);
    let ilosc_bilet = parseInt(document.getElementById("normalne").value);
    let czas = parseInt(document.getElementById("ilosc_godzin").value);
    if (czas <= 4) {
        bilet = ilosc_bilet * 10;
        bilet_ulgowy = ilosc_bilet_ulgowy * 5;
    }
    else if (czas > 4) {
        bilet = ilosc_bilet * 50;
        bilet_ulgowy = ilosc_bilet_ulgowy * 25;
    }
    if (duza_rodzina.checked) {
        wynik = (bilet + bilet_ulgowy) * 0.9;
       
    }
    else {
        wynik = bilet + bilet_ulgowy;

    }
    if (czas <= 4) {
        darmowe = Math.floor(( ilosc_bilet_ulgowy) / 15);
        znizka = darmowe * 10;
        wynik = wynik - znizka;
    }
    else {
        darmowe = Math.floor(( ilosc_bilet_ulgowy) / 15);
        znizka = darmowe * 50;
        wynik = wynik - znizka;
    }
    wypisz.innerText = "cena to:" + wynik;


}
oblicz.addEventListener("click", aquapark);