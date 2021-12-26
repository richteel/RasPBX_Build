const pageFoot = `
    <!-- START: Footer -->
    <footer class="page-footer font-small blue pt-4 navbar-light" id="pageFooter">

        <!-- Footer Links -->
        <div class="container-fluid text-center text-md-left">

            <!-- Grid row -->
            <div class="row">

                <!-- Grid column -->
                <div class="col-md-3 mt-md-0 mt-3 border-right">

                    <!-- START: LOGO -->
                    <a id="home" class="navbar-brand hideLink">
                        <img src="images/Cisco7941G.png" id="logo" />
                        <div class="logoText">
                            RasPBX
                        </div>
                    </a>
                    <!-- END: LOGO -->

                </div>
                <!-- Grid column -->
                
                <hr class="clearfix w-100 d-md-none pb-3" />
                
                <!-- Grid column -->
                <div class="col-md-2 mb-md-0 mb-2">

                    <!-- Links -->
                    <h5 class="text-uppercase">Installation</h5>

                    <ul class="list-unstyled footer-links">
                        <li>
                            <a id="installation_install"></a>
                        </li>
                        <li>
                            <a id="installation_update"></a>
                        </li>
                        <li>
                            <a id="installation_afterupdate"></a>
                        </li>
                        <li>
                            <a id="installation_initialconfig"></a>
                        </li>
                    </ul>

                </div>
                <!-- Grid column -->
                <!-- Grid column -->
                <div class="col-md-2 mb-md-0 mb-3">

                    <!-- Links -->
                    <h5 class="text-uppercase">Remote</h5>

                    <ul class="list-unstyled footer-links">
                        <li>
                            <a id="remote_terminal"></a>
                        </li>
                        <li>
                            <a id="remote_filetransfer"></a>
                        </li>
                    </ul>

                </div>
                <!-- Grid column -->
                <!-- Grid column -->
                <div class="col-md-2 mb-md-0 mb-2">

                    <!-- Links -->
                    <h5 class="text-uppercase">Phones</h5>

                    <ul class="list-unstyled footer-links">
                        <li>
                            <a id="phones_linphone"></a>
                        </li>
                        <li>
                            <a id="phones_pots"></a>
                        </li>
                        <li>
                            <a id="phones_cisco79xx"></a>
                        </li>
                    </ul>

                </div>
                <!-- Grid column -->
                <!-- Grid column -->
                <div class="col-md-2 mb-md-0 mb-2">

                    <!-- Links -->
                    <h5 class="text-uppercase">About</h5>

                    <ul class="list-unstyled footer-links">
                        <li>
                            <a id="about_references"></a>
                        </li>
                    </ul>

                </div>
                <!-- Grid column -->

            </div>
            <!-- Grid row -->

        </div>
        <!-- Footer Links -->

    </footer>
    <!-- END: Footer -->

    <!-- The Modal -->
    <div id="_modal_" class="modal">

      <!-- The Close Button -->
      <span class="close" onclick="closeModal();">&times;</span>

      <!-- Modal Content (The Image) -->
      <img class="modal-content" id="_modalImg_" src="./images/unknown.png" alt="Unknown Image" onclick="modalClick();" />

      <!-- Modal Caption (Image Text) -->
      <div id="_modalCaption_"></div>
    </div>

`;

replaceElementWithContent("pageFooter", pageFoot);
adjustImageUrls('_modal_', siteInfo.imagesPath);

addImgClickEvents();