const $ = (sel) => document.querySelector(sel);
const $$ = (sel) => document.querySelectorAll(sel);

function changeSection(number) {
    $$(".main div").forEach((el, index) => {
        el.style.display = "none"
        if (index == number) el.style.display = "block"
    });
}

$$("input").forEach(el => el.addEventListener("focusout", () => {
    let width = parseInt($(".progress").style.width)

    width = width + 12 > 100 ? 100 : width + 12;
    $(".progress").style.width = `${width}%`;
}))

$(".accept").addEventListener('click', () => console.log(
    ["name", "surname", "date", "street", "number", "city", "phone", "rodo"].map(x =>
        $(`.${x}`).value
    ).join(", ")
))