// Ref: https://www.w3schools.com/howto/howto_css_modal_images.asp

function addImgClickEvents() {
	var imgs = document.getElementsByTagName("img");
	
	for (var i = 0; i < imgs.length; i++) {
		if(imgs[i].id != "_modalImg_") {
			showModal(imgs[i]);
		}
  }
}

function closeModal() {
	var modal = document.getElementById("_modal_");
		
	if(modal==null) {
		return;
	}
	
	modal.style.display = "none";
}

function showModal(imgElement)
{
	imgElement.onclick = function(){
		// Get the modal
		var modal = document.getElementById("_modal_");
		
		if(modal==null) {
			return;
		}
	
		// Get the image and insert it inside the modal - use its "alt" text as a caption
		var modalImg = document.getElementById("_modalImg_");
		var captionText = document.getElementById("_modalCaption_");
		
		if(modalImg==null || captionText==null)
			return;
		
	  modal.style.display = "block";
	  modalImg.src = this.src;
	  captionText.innerHTML = this.alt;
	}
}