//create a function to stop the time
function stopTime() {
    /* check if seconds, minutes and hours are not equal to 0 */
    if (seconds !== 0 || minutes !== 0 || hours !== 0) {
        /* display the full time before reseting the stop watch */
        var fulltime = document.getElementById("fulltime"); //display the full time 
        fulltime.style.display = "block";
        var time = gethours + mins + secs;
        fulltime.innerHTML = 'Fulltime: ' + time;
        // reset the stop watch
        seconds = 0;
        minutes = 0;
        hours = 0;
        secs = '0' + seconds;
        mins = '0' + minutes + ': ';
        gethours = '0' + hours + ': ';
        /* display the stopwatch after it's been stopped */
        var x = document.getElementById("timer");
        var stopTime = gethours + mins + secs;
        x.innerHTML = stopTime; /* display all stop watch control buttons */
        var showStart = document.getElementById('start');
        showStart.style.display = "inline-block";
        var showStop = document.getElementById("stop");
        showStop.style.display = "inline-block"; /* clear the stop watch using the setTimeout( ) return value 'clearTime' as ID */
        clearTimeout(clearTime);
    }
    //if () 
    //    
} 

    // stopTime()
    /* you need to call the stopTime( ) function to terminate the stop watch */
    //window.addEventListener('load', function () {
    //    var stop = document.getElementById("stop");
    //    stop.addEventListener('click', stopTime);
    //});
