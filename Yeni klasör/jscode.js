
function girisYap(){
    let giris=document.getElementById("btnGiris");
    let adsoyad=document.getElementById("adsoyad");
    alert("Giriş Yapıdı. Hoşgeldin "+adsoyad.value);
    adsoyad.style.display = 'none';
    giris.style.display = 'none';
    yazdir();
};
// function yazdir(){
// document.getElementById("yazdir").innerText("Hoşgeldin");
// };
function yazdir(){
   let adSoyadDiv= document.getElementById("yazdir").innerHTML=adsoyad.value;
   adSoyadDiv.style="font-weight: bolder;";
}

let kart1 = document.getElementById("kart1");
kart1.onclick=() => {
    kart1.style="background-image:url(kart1-8.jpg);background-position: center;background-size: 150px;";};

let kart2 = document.getElementById("kart2");
kart2.onclick=() => {
    kart2.style="background-image:url(kart2-9.jpg);background-position: center;background-size: 150px;";};

let kart3 = document.getElementById("kart3");
kart3.onclick=() => {
    kart3.style="background-image:url(kart3-6.jpg);background-position: center;background-size: 150px;";};

let kart4 = document.getElementById("kart4");
kart4.onclick=() => {
    kart4.style="background-image:url(kart4-7.jpg);background-position: center;background-size: 150px;";};

let kart5 = document.getElementById("kart5");
kart5.onclick=() => {
    kart5.style="background-image:url(kart5.jpg);background-position: center;background-size: 150px;";};

let kart6 = document.getElementById("kart6");
kart6.onclick=() => {
    kart6.style="background-image:url(kart3-6.jpg);background-position: center;background-size: 150px;";};

let kart7 = document.getElementById("kart7");
kart7.onclick=() => {
    kart7.style="background-image:url(kart4-7.jpg);background-position: center;background-size: 150px;";};

let kart8 = document.getElementById("kart8");
kart8.onclick=() => {
    kart8.style="background-image:url(kart1-8.jpg);background-position: center;background-size: 150px;";};

let kart9 = document.getElementById("kart9");
kart9.onclick=() => {
    kart9.style="background-image:url(kart2-9.jpg);background-position: center;background-size: 150px;";};
