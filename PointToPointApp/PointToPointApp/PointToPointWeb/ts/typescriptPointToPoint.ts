namespace typepointtopoint {
    let imgcard: any = { name: "imagecard", value: 0 };
    let nmecard: any = { name: "imagecard", value: 0 };
    let currentcard = null;
    let matchedset = false;
    let numberofsetsmatched = 0;
    let imgcardflipped = false;
    let nmecardflipped = false;
    const newTurnButton: HTMLButtonElement = document.querySelector("#btn-newturn");
    const picimglist: string[] = [];
    const picnmelist: string[] = [];
    const allcardlist = [...document.querySelectorAll(".card")] as HTMLButtonElement[];

    const extractNumberFromUrl = (url: string) => parseInt((url.match(/\d+/) || [])[0], 10);

    function toggleButton(buttonId: HTMLButtonElement, activate: boolean) {
        buttonId.classList.toggle("inactive-button", !activate);
        buttonId.disabled = !activate;
    }

    function fillPicArray() {
        picimglist.length = 0;
        picnmelist.length = 0;
        for (let i = 1; i <= 8; i++) {
            picimglist.push(`/images/p${i}p.jpg`);
            picnmelist.push(`/images/n${i}n.jpg`);
        }
    }

    function shuffleArray(array: string[]) {
        for (let i = array.length - 1; i > 0; i--) {
            const j = Math.floor(Math.random() * (i + 1));
            [array[i], array[j]] = [array[j], array[i]];
        }
    }


    function assignImagesToButtons(imageList: string[], buttonSelector: string) {
        const buttons = [...document.querySelectorAll(buttonSelector)] as HTMLButtonElement[];
        shuffleArray(imageList);
        buttons.forEach((button: HTMLButtonElement, index) => {
            const imageUrl = imageList[index];
            const img = document.createElement('img');
            img.src = imageUrl;
            button.appendChild(img);
            button.dataset.cardValue = String(extractNumberFromUrl(imageUrl));
            button.addEventListener('click', handleClick)
            console.log(`Assigned image to button ${index}: ${imageUrl}`);
        });
    }

    function startGame() {
        resetValues();
        numberofsetsmatched = 0;
        allcardlist.forEach(c => {
            c.classList.remove("show-img", "endgame");
            c.classList.add("color");
            c.disabled = false;
        });
        msgnum.value = 9;
        fillPicArray();
        assignImagesToButtons(picimglist, '.imagebutton');
        assignImagesToButtons(picnmelist, '.namebutton');
        newTurnButton.classList.remove("inactive-button");
        newTurnButton.textContent = "New Turn!";
        newTurnButton.classList.replace("btn-info", "btn-warning");
    }

    function resetValues() {
        imgcard.value = 0;
        nmecard.value = 0;
        currentcard = null;
        matchedset = false;
        imgcardflipped = false;
        nmecardflipped = false;
    }

    function handleClick(e: Event) {
        const target = e.currentTarget as HTMLElement;
        currentcard = target.classList.contains("imagebutton") ? imgcard : nmecard;


        if (currentcard === imgcard && !imgcardflipped) {
            imgcard.value = target.dataset.cardValue;
            imgcardflipped = true;
            target.classList.add("show-img");
        }
        else if (currentcard === nmecard && !nmecardflipped) {
            nmecard.value = target.dataset.cardValue;
            nmecardflipped = true;
            target.classList.add("show-img");
        }


        if (imgcardflipped && nmecardflipped) {
            detectMatch();
            newTurnButton.disabled = false;
        }
        else {
            msgnum.value = currentcard === imgcard ? 10 : 11;
        }
    }

    function detectMatch() {
        if (imgcard.value == nmecard.value) {
            numberofsetsmatched++;
            matchedset = true;
            msgnum.value = imgcard.value;
        }
        else {
            matchedset = false;
            msgnum.value = 12;
        }
        toggleButton(newTurnButton, true)

        if (numberofsetsmatched === 8) {
            newTurnButton.textContent = "End Game!";
            newTurnButton.classList.replace("btn-warning", "btn-info")
        }
    }

    function endGame() {
        msgnum.value = 14
        toggleButton(newTurnButton, false);

        allcardlist.forEach(card => (card.classList.add("endgame")));
    }

    function newTurn() {
        msgnum.value = 13;
        if (matchedset) {
            document.querySelectorAll("button.show-img").forEach((button: HTMLButtonElement) => {
                button.disabled = true;
                button.classList.remove("color", "show-img");
            });
            if (numberofsetsmatched === 8) {
                endGame();
            }
        }
        else {
            allcardlist.forEach(card => (card.classList.remove("show-img")));
        }
        resetValues();
        toggleButton(newTurnButton, false)
    }

    let msgnum = {
        _value: 0,
        get value() {
            return this._value;
        },
        set value(newValue) {
            this._value = newValue;
            updateMessage();
        }
    };


    function updateMessage() {
        const msg = [
            "Let's Explore Eretz Yisrael! <br/> Click START to begin the game.",
            "The Ari Hakadosh is buried in Tzfas.",
            "The Churva is a shul in Yerushalayim.",
            "Kever Rochel is in Beis Lechem.",
            "The Kosel is in Yerushalayim.",
            "Mearas Hamachpela is in Chevron.",
            "The kever of Rabbi Meir Bal Haness is in Tiverya.",
            "The kever of Rabi Shimon Bar Yochai is in Meron.",
            "The salt in Yam Hamelech makes everything float in the water.",
            "Click a Button!",
            "Can you find the name of this destination?",
            "Can you find the picture of this destination?",
            "Oops!  Click NEW TURN for another chance.",
            "Where will we travel next?",
            "Congratulations!  You've matched all the pictures!"
        ];
        document.querySelector("#msgText").innerHTML = msg[msgnum.value];
    }

    document.querySelector("#btn-reset").addEventListener("click", startGame)
    document.querySelector("#btn-newturn").addEventListener("click", newTurn)

    updateMessage();
}
