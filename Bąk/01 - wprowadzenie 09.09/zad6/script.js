const pola = document.querySelectorAll('.liczba');
const checkboxes = document.querySelectorAll('.wybrany');
const output = document.getElementById('output');

function liczSume() {
    let suma = 0;

    for (let i = 0; i < pola.length; i++) {
        let wartosc = parseInt(pola[i].value);
        if (isNaN(wartosc)) {
            wartosc = 0;
        }

        if (checkboxes[i].checked) {
            suma += wartosc;
        }
    }

    output.innerText = suma;
}


pola.forEach(p => p.addEventListener('input', liczSume));
checkboxes.forEach(c => c.addEventListener('change', liczSume));
