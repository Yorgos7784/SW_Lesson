// window : 웹브라우저 전체를 의미(398p 참고)
window.addEventListener('load', function () {
        // 클래스명이 sound인 태그를 모두 선택함
        const sounds = document.querySelectorAll(".sound");

        // 클래스명이 pads인 태그의 후손 중에서 div태그들 모두 선택함
        const pads = document.querySelectorAll(".pads div");

        // 클래스명이 visual인 태그를 하나 선택함
        const visual = document.querySelector('.visual');

        // 클래스명이 title인 태그를 하나 선택함
        const title = document.querySelector('.title');

        // 초기화 할때 쓰임
        const colors = [
            "lightblue",
            "brown",
            "cornflowerblue",
            "seagreen",
            "toamto",
            "orchid",
            "rgb(255, 255, 95)"
        ];

        // 재생되는 음악이 끝나면, .visual에서 비쥬얼과 제목 제거
        sounds.forEach(
            function (snd) {
                snd.onended = function () {
                    visual.innerHTML = "";
                    title.innerHTML = "";
                }
            }
        )

        pads.forEach( function(pad, index) {
            pad.addEventListener('click', function(){
                //기존에 재생되는 음악을 중지 시켜야 한다.
               sounds.forEach(function(inx) {
                //console.log(inx);
                inx.pause();
               });
               if(sounds[index]){
                sounds[index].currentTime = 0;
                sounds[index].play();

                //뮤직 제목을 출력해 준다.
                //console.log(sounds[index].src) ;
                const strArray = sounds[index].src.split("sound/");
                console.log(strArray[0]);
                title.innerHTML = strArray[1];
               }
               
                //볼만들고 애니메이션 하기
                //createBubbles(index);
            });
        });

    }

);