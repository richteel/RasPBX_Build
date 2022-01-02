/******************************************************************************
Use the Excel Workbook, DevTools.xlsx, to edit values
in arrays.
 ******************************************************************************/
const defaultFile = "default.html";

const resourceRoots = {
    imagesPath: { local: "~/images/", host: "~/images/" },
    videosPath: { local: "~/videos/", host: "~/videos/" },
    documentsPath: { local: "~/docs/", host: "~/docs/" },
    scriptsPath: { local: "~/js/", host: "~/js/" },
    stylePath: { local: "~/style/", host: "~/style/" }
};

const hostEnvironments = [
    { name: "dev", path: "/pages/dev", debug: true, isHost: false },
    { name: "test", path: "/pages/review", debug: true, isHost:false },
    { name: "prod", path: "/pages", debug: true, isHost: true }
];

// <!--Get your own code at fontawesome.com-->
const includeFiles = [
    { id: "font_awesome", fileType: "script", req_jquery: false, local: "https://kit.fontawesome.com/a12f3f2147.js", host: "https://kit.fontawesome.com/a12f3f2147.js" },
    { id: "js_main", fileType: "script", req_jquery: false, local: "~/js/main.js", host: "~/js/main.js" },
    { id: "js_modal", fileType: "script", req_jquery: false, local: "~/js/modal.js", host: "~/js/modal.js" },
    { id: "jquery_slim_min_js", fileType: "script", req_jquery: false, local: "https://code.jquery.com/jquery-3.5.1.slim.min.js", host: "https://code.jquery.com/jquery-3.5.1.slim.min.js" },
    { id: "jquery_min_js", fileType: "script", req_jquery: false, local: "https://code.jquery.com/jquery-3.5.1.min.js", host: "https://code.jquery.com/jquery-3.5.1.min.js" },
    { id: "js_content", fileType: "script", req_jquery: false, local: "~/js/content.js", host: "~/js/content.js" },
    { id: "js_header", fileType: "script", req_jquery: true, local: "~/js/header.js", host: "~/js/header.js" },
    { id: "js_footer", fileType: "script", req_jquery: true, local: "~/js/footer.js", host: "~/js/footer.js" },
    { id: "style_main", fileType: "style", req_jquery: false, local: "~/style/main.css", host: "~/style/main.css" },
    { id: "style_modal", fileType: "style", req_jquery: false, local: "~/style/modal.css", host: "~/style/modal.css" },
    { id: "style_imagebox", fileType: "style", req_jquery: false, local: "~/style/imageBox.css", host: "~/style/imageBox.css" },
    { id: "style_imgtitle", fileType: "style", req_jquery: false, local: "~/style/imgtitle.css", host: "~/style/imgtitle.css" },
    { id: "style_menu", fileType: "style", req_jquery: false, local: "~/style/menu.css", host: "~/style/menu.css" },
    { id: "style_default", fileType: "style", req_jquery: false, local: "~/style/default.css", host: "~/style/default.css" },
    { id: "bootstrap_min_css", fileType: "style", req_jquery: true, local: "https://cdn.jsdelivr.net/npm/bootstrap@4.6.0/dist/css/bootstrap.min.css", host: "https://cdn.jsdelivr.net/npm/bootstrap@4.6.0/dist/css/bootstrap.min.css" },
    { id: "bootstrap_bundle_min_js", fileType: "script", req_jquery: true, local: "https://cdn.jsdelivr.net/npm/bootstrap@4.6.0/dist/js/bootstrap.bundle.min.js", host: "https://cdn.jsdelivr.net/npm/bootstrap@4.6.0/dist/js/bootstrap.bundle.min.js" },
    { id: "js_menu", fileType: "script", req_jquery: true, local: "~/js/menu.js", host: "~/js/menu.js" }
];

const menuItems = [
    { id: "installation_install", group: "Installation", name: "1. Install RasPBX", url: "~/installation/installation.html", target: "" },
    { id: "installation_update", group: "Installation", name: "2. Update RasPBX", url: "~/installation/update.html", target: "" },
    { id: "installation_afterupdate", group: "Installation", name: "3. Tasks after update", url: "~/installation/afterupdate.html", target: "" },
    { id: "installation_initialconfig", group: "Installation", name: "4. Initial Configuration", url: "~/installation/initalconfig.html", target: "" },
    { id: "remote_terminal", group: "Remote", name: "SSH Terminal", url: "~/remote/terminal.html", target: "" },
    { id: "remote_filetransfer", group: "Remote", name: "SSH File Transfer", url: "~/remote/filetransfer.html", target: "" },
    { id: "remote_mariadb", group: "Remote", name: "MariaDB", url: "~/remote/mariadb.html", target: "" },
    { id: "phones_linphone", group: "Phones", name: "Linphone (Softphone)", url: "~/phones/linphone.html", target: "" },
    { id: "phones_pots", group: "Phones", name: "POTS Connection", url: "~/phones/pots.html", target: "" },
    { id: "phones_cisco79xx_tftp", group: "Cisco79xx", name: "Setup TFTP", url: "~/phones/cisco79xx_tftp.html", target: "" },
    { id: "phones_cisco79xx_xml", group: "Cisco79xx", name: "XML Config", url: "~/phones/cisco79xx_xml.html", target: "" },
    { id: "phones_cisco79xx_reset", group: "Cisco79xx", name: "Reset", url: "~/phones/cisco79xx_reset.html", target: "" },
    { id: "phones_cisco79xx_extension", group: "Cisco79xx", name: "Add Extension(s)", url: "~/phones/cisco79xx_extension.html", target: "" },
    { id: "phones_cisco79xx_directory", group: "Cisco79xx", name: "Directory", url: "~/phones/cisco79xx_directory.html", target: "" },
    { id: "phones_cisco79xx_services", group: "Cisco79xx", name: "Services", url: "~/phones/cisco79xx_services.html", target: "" },
    { id: "more_cisco79xx_misc", group: "More", name: "Cisco 79xx Misc. Info", url: "~/more/cisco79xx_misc.html", target: "" },
    { id: "about_references", group: "About", name: "References", url: "~/about/references.html", target: "" },
    { id: "home", group: "", name: "", url: "~/default.html", target: "" },
    { id: "phones_cisco79xx", group: "Phones", name: "Cisco 79xx", url: "", target: "" }
];

const sitePages = [
    { name: "installation_install", path: "installation/", file: "installation", resourcePath: "installation/installation/" },
    { name: "installation_update", path: "installation/", file: "update", resourcePath: "installation/update/" },
    { name: "installation_afterupdate", path: "installation/", file: "afterupdate", resourcePath: "installation/afterupdate/" },
    { name: "installation_initialconfig", path: "installation/", file: "initalconfig", resourcePath: "installation/initalconfig/" },
    { name: "remote_terminal", path: "remote/", file: "terminal", resourcePath: "remote/terminal/" },
    { name: "remote_filetransfer", path: "remote/", file: "filetransfer", resourcePath: "remote/filetransfer/" },
    { name: "remote_mariadb", path: "remote/", file: "mariadb", resourcePath: "remote/mariadb/" },
    { name: "phones_linphone", path: "phones/", file: "linphone", resourcePath: "phones/linphone/" },
    { name: "phones_pots", path: "phones/", file: "pots", resourcePath: "phones/pots/" },
    { name: "phones_cisco79xx_tftp", path: "phones/", file: "cisco79xx", resourcePath: "phones/cisco79xx/" },
    { name: "phones_cisco79xx_xml", path: "phones/", file: "cisco79xx", resourcePath: "phones/cisco79xx/" },
    { name: "phones_cisco79xx_reset", path: "phones/", file: "cisco79xx", resourcePath: "phones/cisco79xx/" },
    { name: "phones_cisco79xx_extension", path: "phones/", file: "cisco79xx", resourcePath: "phones/cisco79xx/" },
    { name: "phones_cisco79xx_directory", path: "phones/", file: "cisco79xx", resourcePath: "phones/cisco79xx/" },
    { name: "phones_cisco79xx_services", path: "phones/", file: "cisco79xx", resourcePath: "phones/cisco79xx/" },
    { name: "more_cisco79xx_misc", path: "more/", file: "cisco79xx_misc", resourcePath: "more/cisco79xx_misc/" },
    { name: "phones_cisco79xx", path: "phones/", file: "cisco79xx", resourcePath: "phones/cisco79xx/" },
    { name: "about_references", path: "about/", file: "references", resourcePath: "about/references/" },
    { name: "test_header", path: "js/", file: "header", resourcePath: "js/header/" },
    { name: "test_footer", path: "js/", file: "footer", resourcePath: "js/footer/" },
    { name: "sample_mdbootstrap_footer", path: "js/", file: "mdbootstrap_footer", resourcePath: "js/mdbootstrap_footer/" },
    { name: "home", path: "", file: "", resourcePath: "" }
];

const siteInfo = {
    rootPath: "",
    environment: "",
    debug: false,
    isHost: false,
    imagesPath: "",
    videosPath: "",
    documentsPath: "",
    scriptsPath: "",
    stylePath: ""
};

const pageInfo = {
    name: "",
    path: "",
    file: "",
    imagesPath: "",
    videosPath: "",
    documentsPath: ""
};

function addInclude(includeFile) {
    const widgetBody = document.body;

    if (includeFile.req_jquery && !window.jQuery) {
        debugEntry("jQuery not loaded yet - come back in 0.1 seconds");
        setTimeout(function () { addInclude(includeFile); }, 100);
        return;
    }

    debugEntry("addIncludeFile: id = " + includeFile.id);

    if (includeFile.req_jquery && window.jQuery) {
        debugEntry("jQuery has loaded");
    }

    const elem = includeFile.fileType == "script" ? document.createElement("script") : document.createElement("link");
    const path = siteInfo.isHost ? includeFile.host : includeFile.local;
    const incPath = path.startsWith("http") ? path : concatPath(siteInfo.rootPath, path);

    if (includeFile.fileType == "style") {
        elem.rel = 'stylesheet';
        elem.type = 'text/css';
        elem.href = incPath;
    }
    else if (includeFile.fileType == "script") {
        elem.src = incPath;
        elem.crossorigin = "anonymous";
    }
    else
        return;

    widgetBody.appendChild(elem);
}

function addIncludeFiles() {
    debugEntry("addIncludeFiles();");

    const widgetBody = document.body;

    for (const includeFile of includeFiles) {
        addInclude(includeFile);
    }
}

function begin() {
    debugEntry("begin();");

    const url = getCorrectedWindowHref();

    // Find environment
    for (const hostEnvironment of hostEnvironments) {
        const rootUrlLength = url.search(hostEnvironment.path);

        if (rootUrlLength > 0) {
            siteInfo.environment = hostEnvironment.name;
            siteInfo.debug = hostEnvironment.debug;
            siteInfo.isHost = hostEnvironment.isHost;

            siteInfo.rootPath = concatPath(url.substring(0, rootUrlLength), hostEnvironment.path);

            if (!siteInfo.rootPath.endsWith('/'))
                siteInfo.rootPath += '/';
            
            siteInfo.imagesPath = concatPath(siteInfo.rootPath, siteInfo.isHost ? resourceRoots.imagesPath.host : resourceRoots.imagesPath.local);
            siteInfo.videosPath = concatPath(siteInfo.rootPath, siteInfo.isHost ? resourceRoots.videosPath.host : resourceRoots.videosPath.local);
            siteInfo.documentsPath = concatPath(siteInfo.rootPath, siteInfo.isHost ? resourceRoots.documentsPath.host : resourceRoots.documentsPath.local);
            siteInfo.scriptsPath = concatPath(siteInfo.rootPath, siteInfo.isHost ? resourceRoots.scriptsPath.host : resourceRoots.scriptsPath.local);
            siteInfo.stylePath = concatPath(siteInfo.rootPath, siteInfo.isHost ? resourceRoots.stylePath.host : resourceRoots.stylePath.local);

            break;
        }
    }

    // If we did not identify the environment, throw an error
    if (siteInfo.environment == "" || siteInfo.rootPath == "") {
        throw "ERROR: Environment not found";
    }

    // Set page paths
    for (const sitePage of sitePages) {
        let rootUrlLength = 0;

        if (sitePage.path && sitePage.file)
            rootUrlLength = url.search(concatPath(sitePage.path, sitePage.file));
        else if (sitePage.path && !sitePage.file)
            rootUrlLength = url.search(concatPath(sitePage.path, defaultFile));
        else if (!sitePage.path && sitePage.file)
            rootUrlLength = url.search(sitePage.file);
        else
            rootUrlLength = url.search(defaultFile);

        if (rootUrlLength > 0) {
            pageInfo.name = sitePage.name;
            pageInfo.path = concatPath(url.substring(0, rootUrlLength), sitePage.path);
            pageInfo.file = sitePage.file;
            pageInfo.imagesPath = concatPath(siteInfo.imagesPath, sitePage.resourcePath);
            pageInfo.videosPath = concatPath(siteInfo.videosPath, sitePage.resourcePath);
            pageInfo.documentsPath = concatPath(siteInfo.documentsPath, sitePage.resourcePath);

            if (!pageInfo.file)
                pageInfo.file = defaultFile;
            else if (!getExtension(pageInfo.file))
                pageInfo.file += getExtension(defaultFile);

            break;
        }
    }

    // If we did not identify the page, throw an error
    if (pageInfo.name == "") {
        throw "ERROR: Page not found - Add page to sitePages array in load.js";
    }
}

function concatPath(a, b) {
    debugEntry("concatPath();");

    let first = a;
    let last = b;

    if (!first.endsWith("/"))
        first += "/";

    if (last.startsWith("~"))
        last = last.substring(1);

    if (last.startsWith("/"))
        last = last.substring(1);

    if (last.startsWith("http") || last.startsWith("mailto"))
        return last;

    return first + last;
}

function debugEntry(textEntry) {
    if (!siteInfo.debug)
        return;

    console.log(textEntry);
}

function debugShowDetails() {
    debugEntry("debugShowDetails();");

    if (!siteInfo.debug)
        return;

    debugEntry("siteInfo:" + "\u25BC");
    debugEntry(("siteInfo: %o", siteInfo));
    debugEntry("pageInfo:" + "\u25BC");
    debugEntry(("pageInfo: %o", pageInfo));
}

function getCorrectedWindowHref() {
    debugEntry("getCorrectedWindowHref();");

    const url = window.top.location.href.split('?')[0];

    if (url.endsWith(getExtension(defaultFile)))
        return url;
    else
        return concatPath(url, defaultFile);
}

function getExtension(filename) {
    debugEntry("getExtension();");

    const extensionStart = filename.search("\\.");

    if (extensionStart > 0) {
        return filename.substring(extensionStart);
    }
    else
        return "";
}

function getFullPath() {
    debugEntry("getFullPath();");

    if (last.startsWith("http") || last.startsWith("mailto"))
        return last;
    else
        return first + last;
}

// Populate siteInfo and pageInfo objects
begin();

// Show siteInfo and pageInfo values
debugShowDetails();

// Add the include files
addIncludeFiles();