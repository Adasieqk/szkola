const btn = document.querySelector("#btn");
const output = document.querySelector("#output");

btn.addEventListener("click", () => {
    function bmi(wzrost, waga) {
        return waga / ((wzrost / 100) * (wzrost / 100))
    }

    function obliczBMI() {
        const waga = parseFloat(document.querySelector("#waga").value);
        const wzrost = parseFloat(document.querySelector("#wzrost").value);

        const bmiLiczba = bmi(wzrost, waga);

        if (bmiLiczba < 18.5) {
            output.textContent = `Twoje bmi: ${bmiLiczba.toFixed(2)}, za mało!`;
        }
        else if (bmiLiczba > 25) {
            output.textContent = `Twoje bmi: ${bmiLiczba.toFixed(2)}, za duzo!`;
        }
        else {
            output.textContent = `Twoje bmi: ${bmiLiczba.toFixed(2)}, OK!`;
        }
    }

    obliczBMI();
});