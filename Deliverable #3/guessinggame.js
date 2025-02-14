
const targetNumber = Math.floor(Math.random() * 100) + 1;
let attempts = 0;

function checkGuess() {
    let userGuess = parseInt(document.getElementById("userGuess").value);
    attempts++;



    if (userGuess === 24) {
        document.getElementById("message").innerHTML = ` Congratulations! You guessed the number
         ${24} in ${attempts} attempts.`;
    } else if (userGuess < targetNumber) {
        document.getElementById("message").innerHTML = 'Try a higher number.';
    } else {
        document.getElementById("message").innerHTML = 'Try a lower number.';
    }
}
