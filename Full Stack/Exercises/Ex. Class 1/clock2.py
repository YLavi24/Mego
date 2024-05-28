<!DOCTYPE html>
<html lang="en">

<head>
    <meta charset="UTF-8">
    <meta name="viewport" content="width=device-width, initial-scale=1.0">
    <title>Custom Clock</title>
    <style>
        body {
            display: flex;
            justify-content: center;
            align-items: center;
            height: 100vh;
            background-color: #f0f0f0;
            margin: 0;
            font-family: Arial, sans-serif;
        }

        .clock {
            position: relative;
            width: 400px;
            height: 400px;
            background: white;
            border: 5px solid black;
            border-radius: 50%;
        }

        .hand {
            position: absolute;
            width: 50%;
            height: 2px;
            background: black;
            top: 50%;
            left: 50%;
            transform-origin: 100%;
            transform: rotate(90deg);
            transition: transform 0.05s;
        }

        .part-hand {
            width: 35%;
            background: blue;
        }

        .moment-hand {
            width: 45%;
            background: red;
        }

        .mark {
            position: absolute;
            width: 10px;
            height: 10px;
            top: 50%;
            left: 50%;
            transform-origin: center;
        }

        .hour-mark {
            width: 20px;
            height: 20px;
            background: black;
            color: white;
            border-radius: 50%;
            display: flex;
            justify-content: center;
            align-items: center;
        }

        .part-mark {
            width: 10px;
            height: 10px;
            color: blue;
            display: flex;
            justify-content: center;
            align-items: center;
        }

        .digital-clock {
            position: absolute;
            top: 10px;
            width: 100%;
            text-align: center;
            font-size: 24px;
            color: blue;
        }
    </style>
</head>

<body>
    <div class="clock">
        <div class="digital-clock" id="digital-clock"></div>
        <div class="hand hour-hand" id="hour-hand"></div>
        <div class="hand part-hand" id="part-hand"></div>
        <div class="hand moment-hand" id="moment-hand"></div>
    </div>

    <script>
        function createMarks() {
            const clock = document.querySelector('.clock');
            const radius = 180;  // רדיוס השעון

            for (let i = 0; i < 24; i++) {
                const angle = 360 * i / 24 - 90;
                const x = 200 + radius * 0.9 * Math.cos(degreesToRadians(angle));
                const y = 200 + radius * 0.9 * Math.sin(degreesToRadians(angle));
                const mark = document.createElement('div');
                mark.className = 'mark hour-mark';
                mark.style.transform = `translate(${x - 10}px, ${y - 10}px)`;
                mark.textContent = i;
                clock.appendChild(mark);
            }
            for (let i = 0; i < 1080; i += 30) {
                const angle = 360 * i / 1080 - 90;
                const x = 200 + radius * 0.75 * Math.cos(degreesToRadians(angle));
                const y = 200 + radius * 0.75 * Math.sin(degreesToRadians(angle));
                const mark = document.createElement('div');
                mark.className = 'mark part-mark';
                mark.style.transform = `translate(${x - 5}px, ${y - 5}px)`;
                mark.textContent = i;
                mark.style.fontSize = '8px';
                clock.appendChild(mark);
            }
        }

        function degreesToRadians(degrees) {
            return degrees * Math.PI / 180;
        }

        function convertToCustomTime(date) {
            const hour = date.getHours();
            const minute = date.getMinutes();
            const second = date.getSeconds();
            const millisecond = date.getMilliseconds();

            const totalSeconds = hour * 3600 + minute * 60 + second + millisecond / 1000;
            const customHour = hour;
            const customPart = (totalSeconds % 3600) * 1080 / 3600;
            const customMoment = ((totalSeconds % 3600) * 1080 % 3600) / 3600 * 76;

            return { customHour, customPart, customMoment };
        }

        function updateClock() {
            const now = new Date();
            const { customHour, customPart, customMoment } = convertToCustomTime(now);

            const hourHand = document.getElementById('hour-hand');
            const partHand = document.getElementById('part-hand');
            const momentHand = document.getElementById('moment-hand');
            const digitalClock = document.getElementById('digital-clock');

            const hourAngle = 360 * customHour / 24 - 90;
            const partAngle = 360 * customPart / 1080 - 90;
            const momentAngle = 360 * customMoment / 76 - 90;

            hourHand.style.transform = `translate(-50%, -50%) rotate(${hourAngle}deg)`;
            partHand.style.transform = `translate(-50%, -50%) rotate(${partAngle}deg)`;
            momentHand.style.transform = `translate(-50%, -50%) rotate(${momentAngle}deg)`;

            let customPartStr = Math.floor(customPart).toString();
            if (customPartStr.length < 4) {
                customPartStr = customPartStr.padStart(3, '0');
            }

            digitalClock.textContent = `${customHour.toString().padStart(2, '0')}:${customPartStr}:${Math.floor(customMoment).toString().padStart(2, '0')}`;

            requestAnimationFrame(updateClock);
        }

        createMarks();
        updateClock();
    </script>
</body>

</html>