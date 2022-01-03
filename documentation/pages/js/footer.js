﻿const pageFoot = `
    <!-- START: Footer -->
    <footer class="page-footer navbar-light text-md-left" id="pageFooter">
        <!-- bg-dark text-white -->
        <!-- Grid container -->
        <div class="container p-4">
            <!-- Grid container -->
            <!-- Section: Links -->
            <section class="">
                <!--Grid row-->
                <div class="row">
                    <!--Grid column-->
                    <div class="col-lg-2 col-md-6 mb-4 mb-md-0">
                        <!-- START: LOGO -->
                        <a id="home" class="navbar-brand hideLink">
                            <img src="images/Cisco7941G.png" id="logo" />
                            <div class="logoText">
                                RasPBX
                            </div>
                        </a>
                        <!-- END: LOGO -->
                    </div>
                    <!--Grid column-->
                    <!--Grid column-->
                    <div class="col-lg-2 col-md-6 mb-4 mb-md-0">
                        <h5 class="text-uppercase">Installation</h5>

                        <ul class="list-unstyled footer-links">
                            <li>
                                <a id="installation_install"></a>
                            </li>
                            <li>
                                <a id="installation_update"></a>
                            </li>
                            <li>
                                <a id="installation_initialconfig"></a>
                            </li>
                            <li>
                                <a id="installation_afterupdate"></a>
                            </li>
                        </ul>
                    </div>
                    <!--Grid column-->
                    <!--Grid column-->
                    <div class="col-lg-2 col-md-6 mb-4 mb-md-0">
                        <h5 class="text-uppercase">Remote</h5>

                        <ul class="list-unstyled footer-links">
                            <li>
                                <a id="remote_terminal"></a>
                            </li>
                            <li>
                                <a id="remote_filetransfer"></a>
                            </li>
                            <li>
                                <a id="remote_mariadb"></a>
                            </li>
                        </ul>
                    </div>
                    <!--Grid column-->
                    <!--Grid column-->
                    <div class="col-lg-2 col-md-6 mb-4 mb-md-0">
                        <h5 class="text-uppercase">Phones</h5>

                        <ul class="list-unstyled footer-links">
                            <li>
                                <a id="phones_linphone"></a>
                            </li>
                            <li>
                                <a id="phones_pots"></a>
                            </li>
                            <li class="subMenu">
                                <span id="phones_cisco79xx"></span>
                                <ul>
                                    <li>
                                        <a id="phones_cisco79xx_tftp"></a>
                                    </li>
                                    <li>
                                        <a id="phones_cisco79xx_xml"></a>
                                    </li>
                                    <li>
                                        <a id="phones_cisco79xx_reset"></a>
                                    </li>
                                    <li>
                                        <a id="phones_cisco79xx_extension"></a>
                                    </li>
                                    <li>
                                        <a id="phones_cisco79xx_directory"></a>
                                    </li>
                                    <li>
                                        <a id="phones_cisco79xx_services"></a>
                                    </li>
                                </ul>
                            </li>
                        </ul>
                    </div>
                    <!--Grid column-->
                    <!--Grid column-->
                    <div class="col-lg-2 col-md-6 mb-4 mb-md-0">
                        <h5 class="text-uppercase">More</h5>

                        <ul class="list-unstyled footer-links">
                            <li>
                                <a id="more_cisco79xx_misc"></a>
                            </li>
                            <li>
                                <a id="more_windows_utiltiy"></a>
                            </li>
                        </ul>
                    </div>
                    <!--Grid column-->
                    <!--Grid column-->
                    <div class="col-lg-2 col-md-6 mb-4 mb-md-0">
                        <h5 class="text-uppercase">About</h5>

                        <ul class="list-unstyled footer-links">
                            <li>
                                <a id="about_references"></a>
                            </li>
                        </ul>
                    </div>
                    <!--Grid column-->
                </div>
                <!--Grid row-->
            </section>
            <!-- Section: Links -->
        </div>
        <!-- Grid container -->
        <!-- Copyright -->
        <div class="text-center p-3 copyright">
            © 2020 Copyright:
            <a href="https://teelsys.com/">TeelSys.com</a>
        </div>
        <!-- Copyright -->
    </footer>

    <!-- The Modal -->
    <div id="_modal_" class="modal">

        <!-- The Close Button -->
        <span class="close" onclick="closeModal();">&times;</span>

        <!-- Modal Content (The Image) -->
        <img class="modal-content" id="_modalImg_" src="./images/unknown.png" alt="Unknown Image" onclick="modalClick();" />

        <!-- Modal Caption (Image Text) -->
        <div id="_modalCaption_"></div>
    </div>
    <!-- END: Footer -->
`;

replaceElementWithContent("pageFooter", pageFoot, "div");
adjustImageUrls('_modal_', siteInfo.imagesPath);

addImgClickEvents();