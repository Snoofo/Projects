// initialise canvas to 2d
var canvas = document.getElementById("myCanvas");
var ctx = canvas.getContext("2d");
// set width and height variables
var x = canvas.width / 2;
var y = canvas.height - 30;
// set size of ball
var ballRadius = 10;
// set x and y movement coordinates
var dx = 1;
var dy = 1;
// set speed of ball
var speed = 10;
// set paddle size and position
var paddleHeight = 10;
var paddleWidth = 75;
var paddleX = (canvas.width - paddleWidth) / 2;
var space = 10;
// set keyboard inputs
var leftPressed = false;
var rightPressed = false;

function draw()
{
    ctx.clearRect(0, 0, canvas.width, canvas.height);
    drawBall();
    drawPaddle();

    if (x + dx > canvas.width-ballRadius || x + dx < ballRadius)
    {
        dx = -dx;
    }
    if (y + dy < ballRadius)
    {
        dy = -dy;
    }
    else if (y + dy > canvas.height - ballRadius - space)
    {
        if (x > paddleX && x < paddleX + paddleWidth)
        {
            speed += 10;
            dy = -dy;
        }
        else
        {
            alert("GAME OVER");
            document.location.reload();
        }
    }
    if (rightPressed && paddleX < canvas.width - paddleWidth) {
        paddleX += 7;
    }
    else if (leftPressed && paddleX > 0) {
        paddleX -= 7;
    }

    x += dx;
    y += dy;
}

function drawBall()
{
    ctx.beginPath();
    ctx.arc(x, y, ballRadius, 0, Math.PI * 2);
    ctx.fillStyle = "blue";
    ctx.fill();
    ctx.closePath();
}

function drawPaddle()
{
    ctx.beginPath();
    ctx.rect(paddleX, canvas.height - paddleHeight - space, paddleWidth, paddleHeight);
    ctx.fillStyle = "black";
    ctx.fill();
    ctx.closePath();
}

document.addEventListener("keydown", keyDownHandler, false);
document.addEventListener("keyup", keyUpHandler, false);
function keyDownHandler(e)
{
    if (e.keyCode == 39)
    {
        rightPressed = true;
    }
    else if (e.keyCode == 37)
    {
        leftPressed = true;
    }
}
function keyUpHandler(e)
{
    if (e.keyCode == 39)
    {
        rightPressed = false;
    }
    else if (e.keyCode = 37)
    {
        leftPressed = false;
    }
}
setInterval(draw, speed);