function zamien(zmien) {
    const quote1 = document.querySelector("#quote1");
    const quote2 = document.querySelector("#quote2");
    const quote3 = document.querySelector("#quote3");

    if (zmien === "quote1") {
        quote1.style.display = "none";
        quote2.style.display = "block";
    }
    else if (zmien === "quote2") {
        quote2.style.display = "none";
        quote3.style.display = "block";
    }
    else if (zmien === "quote3") {
        quote3.style.display = "none";
        quote1.style.display = "block";
    }

}

