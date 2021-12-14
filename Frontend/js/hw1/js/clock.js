let fullName = prompt("İsminizi giriniz.");

let myName = document.querySelector("#myName");
myName.innerHTML = fullName;

function showTime() {
    let myClock = document.querySelector("#myClock");

    let today = new Date();
    let time = today.getHours() + ":" + today.getMinutes() + ":" + today.getSeconds();

    let day;
    switch (new Date().getDay()) {
        case 0:
            day = " Pazar";
            break;
        case 1:
            day = " Pazartesi";
            break;
        case 2:
            day = " Salı";
            break;
        case 3:
            day = " Çarşamba";
            break;
        case 4:
            day = " Perşembe";
            break;
        case 5:
            day = " Cuma";
            break;
        case 6:
            day = " Cumartesi";
            break;
    }

    myClock.innerHTML = time + day;

    setInterval(showTime, 1000);
}

document.addEventListener('DOMContentLoaded', showTime, false);