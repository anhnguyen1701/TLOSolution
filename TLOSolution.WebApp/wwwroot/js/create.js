let Password1,Password2,Login__1,Password3,Send,Login1,ForgotAnimation,ForgotAnimation1,Loading,Password4,Login__2;

$(function(){

    Send = $('#data-send')
    Password1 = $('#data__password--1')
    Password2 = $('#data__password--2')
    Password3 = $('#data__password--3')
    Password4 = $('#data__password--4')
    Login__1 = $("#data__login--1")
    Login__2 = $("#data__login--2")
    Login1 = $("#login--1")
    ForgotAnimation = $("#forgot--animation")
    ForgotAnimation1 = $("#forgot__animation--1")
    Loading = $(".move")
    clicksendEmail()
    clickcheckCode()
    clickopenEmail()
    clickcomfirmPassword()
    
})



function clicksendEmail(){
    Send.click(
        function(){
            ForgotAnimation.addClass("show")
            setTimeout(() => {
                Password1.addClass('d-none')
                Password2.removeClass("d-none")
                Password3.addClass("d-none")
                Password4.addClass("d-none")
                setTimeout(() => {
                    ForgotAnimation1.addClass("show--1")
                }, 20);
            }, 4000);
        }
    )

}
function clickcheckCode(){
    Login__1.click(
        function(){
            alert("Hệ thống đang kiểm tra")
            // Loading.removeClass('d-none')
            setTimeout(() => {
                Password1.addClass('d-none')
                Password2.addClass("d-none")
                Password3.removeClass("d-none")
                Password4.addClass("d-none")
            }, 1000);
        }
    )
}

function clickcomfirmPassword(){
    Login__2.click(
        function(){
            setTimeout(() => {
                Password1.addClass('d-none')
                Password2.addClass("d-none")
                Password3.addClass("d-none")
                Password4.removeClass("d-none")
            }, 200);
        }
    )
}

function clickopenEmail(){
    Login1.click(
        function(){
            ForgotAnimation.removeClass("show")
            ForgotAnimation1.removeClass("show--1")
            Password1.removeClass('d-none')
            Password2.addClass("d-none")
            Password3.addClass("d-none")
        }
    )
}

