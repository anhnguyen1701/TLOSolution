const views1 = document.getElementsByClassName("box ");
const views2 = document.getElementsByClassName("content-last-list ");
for (var i = 0 ; i < views1.length; i++) {
   views1[i].addEventListener('click' , chuyenHuong) ; 
}
for (var i = 0 ; i < views2.length; i++) {
   views2[i].addEventListener('click' , chuyenHuong) ; 
}
var views3 = document.getElementById('logo');
if(views3){
   views3.addEventListener('click', chuyenHuong1,false) ;
}
function chuyenHuong(){
    location.replace("view.html");
};
function chuyenHuong1() {  
   location.replace("index.html");
}



var index = 1;
   changeImg = function() {
       
       var images = ["image/slider/1.jpg","image/slider/2.jpg","image/slider/3.jpg"];
       document.getElementById('img').src = images[index];
       index++;
       if(index===3){
           index=0;
       }

   }
setInterval(changeImg,3000);


var logout = document.getElementById('logout');
if(logout){
   logout.addEventListener('click', chuyenHuong1,false) ;
}

var login = document.getElementById('login');
if(login){
   login.addEventListener('click', () => {
      location.replace("login.html");
   },false) ;
}

var register = document.getElementById('register');
if(register){
   register.addEventListener('click', () => {
      location.replace("Register.html");
   },false) ;
}

var search = document.getElementById('search-icon');
if(search){
   search.addEventListener('click', () => {
      location.replace("Search.html");
   },false) ;
}
const views4 = document.getElementsByClassName("text-h3");
for (var i = 0 ; i < views4.length; i++) {
   views4[i].addEventListener('click' , chuyenHuong) ; 
}