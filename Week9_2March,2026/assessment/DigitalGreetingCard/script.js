const balloons = document.querySelectorAll(".balloon");
const sound = document.getElementById("celebrationSound");

balloons.forEach(balloon => {
    balloon.addEventListener("click", function(){
        sound.currentTime = 0;
        sound.play();

        // Balloon pop effect
        balloon.style.transform = "scale(1.5)";
        balloon.style.opacity = "0";

        setTimeout(() => {
            balloon.remove();
        }, 300);
    });
});