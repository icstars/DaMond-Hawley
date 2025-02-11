let redball = document.getElementById("redball");
 

document.onkeydown = function(e) {
    let left = parseInt(redball.style.left) || 100;
    let top = parseInt(redball.style.top) || 100;

    if (e.keyCode == 37) { // Left Arrow
        redball.style.left = (left - 10) + "px";
    }
    if (e.keyCode == 38) { // Up Arrow
        redball.style.top = (top - 10) + "px";
    }
    if (e.keyCode == 39) { // Right Arrow
        redball.style.left = (left + 10) + "px";
    }
    if (e.keyCode == 40) { // Down Arrow
        redball.style.top = (top + 10) + "px";
    }
};


function moveLeft() {
    let left = parseInt(redball.style.left) || 100;
    redball.style.left = (left - 10) + "px";
}

function moveUp() {
    let top = parseInt(redball.style.top) || 100;
    redball.style.top = (top - 10) + "px";
}

function moveRight() {
    let left = parseInt(redball.style.left) || 100;
    redball.style.left = (left + 10) + "px";
}

function moveDown() {
    let top = parseInt(redball.style.top) || 100;
    redball.style.top = (top + 10) + "px";
}