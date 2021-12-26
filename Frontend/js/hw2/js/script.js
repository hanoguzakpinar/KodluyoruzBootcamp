let addSpanDOM = document.querySelector("#liveToastBtn");
let ulDOM = document.querySelector("#list");
let liElements = document.getElementsByTagName("li");

let option = { animation: true, delay: 2000 };
let toastSuccess = document.querySelector("#liveToast1");
let toastFail = document.querySelector("#liveToast2");


addSpanDOM.addEventListener("click", addElement);
ulDOM.addEventListener("click", checkItem);

for (let i = 0; i < liElements.length; i++) {
    let remove = document.createElement("span");
    remove.classList.add("close");
    remove.innerHTML = "X";
    liElements[i].appendChild(remove);
}


function removeBtns() {
    let removeDOM = document.querySelectorAll(".close");
    //removeDOM.addEventListener("click", removeItem);

    for (let i = 0; i < removeDOM.length; i++) {
        removeDOM[i].addEventListener("click", removeItem);
    }
}
removeBtns();

function removeItem(event) {
    console.log(event)
    event.target.parentElement.classList.add("d-none")
}

function checkItem(event) {
    event.target.classList.add("checked");
}
function addElement(event) {
    event.preventDefault();
    let taskDOM = document.querySelector("#task");
    let liDOM = document.createElement("li");
    if (taskDOM.value) {
        liDOM.innerHTML = taskDOM.value;

        let remove = document.createElement("span");
        remove.classList.add("close");
        remove.innerHTML = "X";
        liDOM.appendChild(remove);

        ulDOM.appendChild(liDOM);

        var toastElement = new bootstrap.Toast(toastSuccess, option);
        toastElement.show();

        taskDOM.value = "";
        removeBtns();
    }
    else {
        var toastElement = new bootstrap.Toast(toastFail, option);
        toastElement.show();
    }
}