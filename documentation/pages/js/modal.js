// Ref: https://www.w3schools.com/howto/howto_css_modal_images.asp

const doNotShowImgIds = ['_modalImg_', 'logo'];

const imgs = [];
let imgsCount = 0;
let currentImgIdx = 0;

function addImgClickEvents() {
    if (imgs.length == 0) {
        for (img of document.getElementsByTagName("img")) {
            if (doNotShowImgIds.indexOf(img.id) < 0 && !img.classList.contains("None") && !img.href)
                imgs.push(img);
        }

        imgsCount = imgs.length;
    }

    if (imgsCount == 0)
        return;

    for (var i = 0; i < imgs.length; i++) {
        imgs[i].modal = i;
        showModal(imgs[i]);
    }
}

function changeImage(incrementCount) {
    // Unknown error
    if (currentImgIdx < 0 || currentImgIdx > imgs.length - 1) {
        return;
    }

    let nextImgIdx = currentImgIdx + incrementCount;

    if (nextImgIdx < 0) {
        //return;
        nextImgIdx = imgs.length - 1;
    }
    if (nextImgIdx >= imgs.length) {
        //return;
        nextImgIdx = 0;
    }

    if (!imgs[nextImgIdx].hasOwnProperty("modal")) {
        return;
    }

    imgs[nextImgIdx].click();
}

function closeModal() {
    let modal = document.getElementById("_modal_");

    if (modal == null) {
        return;
    }

    modal.style.display = "none";
}

function modalClick(e) {
    const modalImg = document.getElementById("_modalImg_");

    const imgPosX = modalImg.offsetLeft;
    const imgPosY = modalImg.offsetTop;
    const imgWidth = modalImg.width;
    let PosX = 0;
    let PosY = 0;

    if (!e) e = window.event;

    if (e.pageX || e.pageY) {
        PosX = e.pageX;
        PosY = e.pageY;
    }
    else if (e.clientX || e.clientY) {
        PosX = e.clientX + document.body.scrollLeft + document.documentElement.scrollLeft;
        PosY = e.clientY + document.body.scrollTop + document.documentElement.scrollTop;
    }

    PosX = PosX - imgPosX;
    PosY = PosY - imgPosY;

    if (PosX < imgWidth / 2) {
        changeImage(-1);
    }
    else {
        changeImage(1);
    }
}

function showModal(imgElement) {
    imgElement.onclick = function () {
        // Get the modal
        let modal = document.getElementById("_modal_");

        if (modal == null) {
            return;
        }

        // Get the image and insert it inside the modal - use its "alt" text as a caption
        let modalImg = document.getElementById("_modalImg_");
        let captionText = document.getElementById("_modalCaption_");

        if (modalImg == null || captionText == null)
            return;

        modal.style.display = "block";
        modalImg.src = this.src;
        modalImg.alt = this.alt;
        currentImgIdx = this.modal;
        captionText.innerHTML = this.alt + "<br /><i>" + (currentImgIdx + 1) + " of " + imgsCount + " images</i>";
    }
    imgElement.title = imgElement.alt;
}