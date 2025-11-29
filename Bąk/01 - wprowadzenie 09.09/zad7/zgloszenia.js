let button=document.getElementById("button");
let klient=document.getElementById("klient");
let wypisz=document.getElementById("wypisz");
function oblicz_zgloszenia(){
    let zgloszenia=document.getElementById("zgloszenia").value;
    let cena;
if(zgloszenia<=51){
    cena=2*zgloszenia;

}
else if(zgloszenia>=51 && zgloszenia<100){
    cena=1.5*zgloszenia;
}
else {
    cena=1*zgloszenia;
}
if(klient.checked){
    cena*=0.8;

}
wypisz.innerText="cena to: "+cena+" zl";

}
button.addEventListener('click',oblicz_zgloszenia);