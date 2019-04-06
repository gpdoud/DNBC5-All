function playGames() {
    var highScore = 0;
    var idx = 0;
    while(idx < 100) {
        var gameScore = playOneGame();
        if(gameScore > highScore) {
            highScore = gameScore;
        }
        idx++;
    }
    var answerCtrl = document.getElementById("answer");
    answerCtrl.innerText = highScore;
}
function playOneGame() {
    var total = 0;
    var roll = rollTheDie();
    while(roll != 1) {

        total += roll;

        roll = rollTheDie();
    }
    return total;
}
function rollTheDie() {
    return Math.floor(Math.random() * 6) + 1;
}