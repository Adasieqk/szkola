const $ = (selector) => document.querySelector(selector);

const submit = $("#submit");

submit.addEventListener("click", (event) => {

    const imie = $("#imie").value.toUpperCase();
    const nazwisko = $("#nazwisko").value.toUpperCase();
    const email = $("#email").value;
    const zgloszenie = $("#zgloszenie").value;
    const regulamin = $("#regulamin");
    const output = $("#output");

    if (!regulamin.checked) {
        output.style.color = "red";
        output.textContent = "Musisz zaakceptować regulamin";
    }
    else {
        output.style.color = "navy";
        output.innerHTML = `${imie} ${nazwisko} <br> 
        Treść twojej sprawy: ${zgloszenie}
        `;
    }
});