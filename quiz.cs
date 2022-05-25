* {
  user-select: none;
  box-sizing: border-box;
  margin: 0;
  padding: 0;
}

body {
  display: grid;
  place-items: center;
  height: 100vh;
}
body .game-zone {
  display: flex;
  flex-direction: column;
  align-items: center;
}
body .game-zone .quiz-zone {
  padding: 1rem;
  width: 800px;
  height: 500px;
  display: grid;
  grid-template-rows: 0.2fr 1fr;
}
body .game-zone .quiz-zone .quiz {
  display: flex;
  justify-content: space-around;
  padding: 1rem;
  border: 1px solid lightblue;
  background-color: #efed40;
}
body .game-zone .quiz-zone .quiz span {
  font-size: 30px;
  border: 1px solid black;
  padding: 0.5rem;
}
body .game-zone .quiz-zone .quiz span:not(:nth-child(2)) {
  background-color: red;
  color: #fff;
}
body .game-zone .quiz-zone .answers {
  display: flex;
  flex-direction: column;
}
body .game-zone .quiz-zone .answers .row {
  display: flex;
  justify-content: space-around;
  align-items: center;
  height: 50%;
}
body .game-zone .quiz-zone .answers .row .answer {
  font-size: 40px;
  background-color: lightblue;
  padding: 0.5rem;
  cursor: pointer;
  transition: transform 0.3s linear;
}
body .game-zone .quiz-zone .answers .row .answer:active {
  transform: scale(0.95);
}
body .game-zone .points {
  width: 1200px;
  height: 50px;
  display: none;
  grid-template-columns: repeat(auto-fit, minmax(50px, 1fr));
  border: 1px solid lightblue;
  padding: 0.5rem;
}
body .game-zone .points .point {
  width: 50px;
  color: #fff;
}
body .game-zone .points .point--success {
  background-color: green;
}
body .game-zone .points .point--fail {
  background-color: red;
}
body .game-zone .points .point--timeout {
  background-color: black;
}

.modal-bg {
  position: fixed;
  width: 100%;
  height: 100vh;
  top: 0;
  left: 0;
  background: rgba(0, 0, 0, 0.5);
  display: none;
  justify-content: center;
  align-items: center;
}
.modal-bg .modal {
  background: #fff;
  width: 25%;
  height: 70%;
  display: flex;
  flex-direction: column;
  justify-content: center;
  align-items: center;
  gap: 10px;
}
.modal-bg .modal .btns {
  display: flex;
  gap: 10px;
}
.modal-bg .modal .btns .result {
  background: #fff;
  color: lightblue;
  border: 1px solid #007bff;
  border-radius: 8px;
  padding: 10px;
  transition: 0.5s;
  cursor: pointer;
}
.modal-bg .modal .btns .result:hover {
  color: #2a2a72;
  background: #007bff;
}
.modal-bg .modal .btns .newGame {
  background: #fff;
  color: #efed40;
  border: 1px solid coral;
  border-radius: 8px;
  padding: 10px;
  transition: 0.5s;
  cursor: pointer;
}
.modal-bg .modal .btns .newGame:hover {
  color: #2a2a72;
  background: #007bff;
}

.hidden {
  display: none !important;
}
