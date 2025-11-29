const grade = document.getElementById("grade");
const btn = document.getElementById("btn");
const avgOut = document.getElementById("avgOut");
const minOut = document.getElementById("minOut");
const maxOut = document.getElementById("maxOut");

let grades = [];

btn.addEventListener("click", () => {

    if (grade.value > 6) {
        grades.push(6);
    }
    else if (grade.value < 1) {
        grades.push(1);
    }
    else {
        grades.push(grade.value);
    }

    grade.value = "";
    grade.focus();

    let total = 0;
    let avg = 0;

    for (let i = 0; i < grades.length; i++) {
        total += parseFloat(grades[i]);
    }

    avg = (total / grades.length).toFixed(2);
    avgOut.textContent = `Średnia ocen: ${avg}`;

    let min = Math.min(...grades);
    let max = Math.max(...grades);

    minOut.textContent = `Najniższa ocena: ${min}`;
    maxOut.textContent = `Najwyższa ocena: ${max}`;


});