let ilosckm = document.querySelector("#ilosckm");
let gdansk = document.querySelector("#gdansk");
let output = document.querySelector("#output");

function obliczDostawe() {
    if (gdansk.checked === true) {
        output.innerHTML = "Dowieziemy ci pizzę za darmo";
    }
    else if (gdansk.checked === false) {
        let km = ilosckm.value;
        let koszt = km * 2;
        output.innerHTML = `Dowód będzie cię kosztował ${koszt} zł`;
    }
}