const btn = document.getElementById("btn");
const output = document.getElementById("output");

btn.addEventListener("click", () => {
    let number = Number(document.getElementById("number").value);
    if (isNaN(number)) {
        output.textContent = "Wprowadz poprawna liczbe";
    }
    else {
        let binary = number.toString(2);

        let binaryArray = [];
        for (let i = binary.length; i > 0; i -= 4) {
            binaryArray.unshift(binary.slice(Math.max(i - 4, 0), i));
        }

        let wynik = binaryArray.join(" ");
        output.innerHTML = wynik + "<sub>(2)</sub>";
    }
});