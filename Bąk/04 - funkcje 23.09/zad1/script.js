const btn = document.querySelector("#btn");
const out = document.querySelector("#out");


btn.addEventListener("click", () => {

    function suma(a, b) {
        return a + b;
    }

    const n1 = parseFloat(document.querySelector("#n1").value);
    const n2 = parseFloat(document.querySelector("#n2").value);

    const wynik = suma(n1, n2);
    out.textContent = wynik;

})