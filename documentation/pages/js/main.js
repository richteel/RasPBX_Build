﻿function addMenuLinks(elemId) {
    debugEntry("addMenuLinks('" + elemId + "');");

    for (const mnu of menuItems) {
        let elem = document.getElementById(mnu.id);

        if (elem) {
            if (mnu.url) {
                elem.href = concatPath(siteInfo.rootPath, mnu.url);

                if (mnu.url.endsWith("/"))
                    elem.href += "default.html";

                if (mnu.target)
                    elem.target = mnu.target;
                else
                    elem.target = "_top";

                if (mnu.name)
                    elem.text = mnu.name;
            }
            else {
                /* let lblElem = document.createElement("span");
                lblElem.innerHTML = mnu.name;
                
                elem.parentNode.replaceChild(lblElem, elem); */
                elem.innerHTML = mnu.name;
            }

            elem.id = "";
        }
        else {
            debugEntry("Element '" + mnu.id + "' not found");
        }
    }
}

function adjustImageUrls(elemId, resourceUrl) {
    debugEntry("adjustImageUrls('" + elemId + "', '" + resourceUrl + "');");

    let allImages = document.getElementsByTagName("img");

    if (elemId.length > 0) {
        let elem = document.getElementById(elemId);
        if (elem)
            allImages = elem.getElementsByTagName("img");
        else
            return;
    }

    for (const image of allImages) {
        const segments = image.src.split('/');
        let imgFile = segments[segments.length - 1];

        imgFile = concatPath(resourceUrl, imgFile);
        image.src = imgFile;
    }
}

function replaceElementWithContent(elementId, htmlText, elementTag = "any") {
    if (htmlText.length < 100)
        debugEntry("replaceElementWithContent('" + elementId + "', '" + htmlText + "');");
    else
        debugEntry("replaceElementWithContent('" + elementId + "', '" + htmlText.substring(0, 20) + "..." + htmlText.substring(htmlText.length - 21, htmlText.length - 1) + "');");

    const elem = document.getElementById(elementId);

    if (elem == null)
        return;

    if (elementTag && elementTag != "any") {
        if (elem.tagName != elementTag.toUpperCase()) {
            addMenuLinks(elementId);
            adjustImageUrls(elementId, siteInfo.imagesPath);
            return;
        }
    }

    elem.outerHTML = htmlText;

    addMenuLinks(elementId);
    adjustImageUrls(elementId, siteInfo.imagesPath);
}





// Modify the Image URLs to load from the page's static resources folder
//adjustImageUrls("", pageInfo.imagesPath);

// Modify video URLs if we are running locally
//adjustVideoUrls("", pageInfo.videosPath)


// Add indicator to all external links
//window.addEventListener("load", modifyExternalLinks, false);