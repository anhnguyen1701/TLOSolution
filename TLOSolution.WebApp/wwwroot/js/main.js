var index = 1;
changeImg = function () {

    var images = ["image/slider/1.jpg", "image/slider/2.jpg", "image/slider/3.jpg"];
    document.getElementById('img').src = images[index];
    index++;
    if (index === 3) {
        index = 0;
    }

}
setInterval(changeImg, 3000);


var logout = document.getElementById('logout');
if (logout) {
    logout.addEventListener('click', chuyenHuong1, false);
}

var login = document.getElementById('login');
if (login) {
    login.addEventListener('click', () => {
        location.replace("login.html");
    }, false);
}

var register = document.getElementById('register');
if (register) {
    register.addEventListener('click', () => {
        location.replace("Register.html");
    }, false);
}

var search = document.getElementById('search-icon');
if (search) {
    search.addEventListener('click', () => {
        location.replace("Search.html");
    }, false);
}
const views4 = document.getElementsByClassName("text-h3");
for (var i = 0; i < views4.length; i++) {
    views4[i].addEventListener('click', chuyenHuong);
}


function GetSelectedTextValue() {
    var ddlFruits = document.getElementById("combobox99");
    var selectedText = ddlFruits.options[ddlFruits.selectedIndex].innerHTML;
    var selectedValue = ddlFruits.value;

    document.getElementById('CategoryId').value = selectedValue;
    return false;

}