const pageHead = `
		<a class="skip-main" href="#main">Skip to main content</a>
        <!-- START: Header -->
        <nav class="navbar navbar-expand-lg navbar-dark" id="pageHeader">
			<!-- START: LOGO -->
			<a id="home" class="navbar-brand hideLink">
				<img src="images/Cisco7941G.png" id="logo" />
				<div class="logoText">
					RasPBX
				</div>
			</a>
			<!-- END: LOGO -->
			<!-- Hamburger Menu Icon for small screens -->
			<button class="navbar-toggler" type="button" data-toggle="collapse" data-target="#navbarSupportedContent" aria-controls="navbarSupportedContent" aria-expanded="false" aria-label="Toggle navigation">
				<span class="navbar-toggler-icon"></span>
			</button>

			<div class="collapse navbar-collapse" id="navbarSupportedContent">
				<!-- START: MENU CONTENT -->
				<ul class="nav navbar-nav mr-auto">


					<li class="nav-item dropdown">
						<a href="#" id="navbarDropdownInstallation" class="nav-link dropdown-toggle" data-toggle="dropdown" role="button" aria-haspopup="true" aria-expanded="false">
							<span class="nav-label">Installation</span> <span class="caret"></span>
						</a>
						<ul class="dropdown-menu" aria-labelledby="navbarDropdownInstallation">
							<li><a href="#" id="installation_install" class="dropdown-item"></a></li>
							<li><a href="#" id="installation_update" class="dropdown-item"></a></li>
							<li><a href="#" id="installation_afterupdate" class="dropdown-item"></a></li>
							<li><a href="#" id="installation_initialconfig" class="dropdown-item"></a></li>
						</ul>
					</li>


					<li class="nav-item dropdown">
						<a href="#" id="navbarDropdownRemote" class="nav-link dropdown-toggle" data-toggle="dropdown" role="button" aria-haspopup="true" aria-expanded="true">
							<span class="nav-label">Remote</span> <span class="caret"></span>
						</a>
						<ul class="dropdown-menu" aria-labelledby="navbarDropdownRemote">
							<li><a href="#" id="remote_terminal" class="dropdown-item"></a></li>
							<li><a href="#" id="remote_filetransfer" class="dropdown-item"></a></li>
						</ul>
					</li>


					<li class="dropdown">
						<a href="#" id="navbarDropdownPhones" class="nav-link dropdown-toggle" data-toggle="dropdown" role="button" aria-haspopup="true" aria-expanded="true">
							<span class="nav-label">Phones</span> <span class="caret"></span>
						</a>
						<ul class="dropdown-menu" aria-labelledby="navbarDropdownPhones">
							<li><a href="#" id="phones_linphone" class="dropdown-item"></a></li>
							<li><a href="#" id="phones_pots" class="dropdown-item"></a></li>
							<li class="dropdown-submenu">
								<a href="#" id="phones_cisco79xx" class="dropdown-toggle dropdown-item" data-toggle="dropdown" role="button" aria-haspopup="true" aria-expanded="false">
									<span class="nav-label">Cisco 79xx</span> <span class="caret"></span>
								</a>
								<ul class="dropdown-menu">
									<li><a href="#" id="phones_cisco79xx_reset" class="dropdown-item"></a></li>
									<li><a href="#" id="phones_cisco79xx_tftp" class="dropdown-item"></a></li>
									<li><a href="#" id="phones_cisco79xx_xml" class="dropdown-item"></a></li>
									<li><a href="#" id="phones_cisco79xx_directory" class="dropdown-item"></a></li>
									<li><a href="#" id="phones_cisco79xx_services" class="dropdown-item"></a></li>
								</ul>
							</li>
						</ul>
					</li>


					<li class="dropdown">
						<a href="#" id="navbarDropdownAbout" class="nav-link dropdown-toggle" data-toggle="dropdown" role="button" aria-haspopup="true" aria-expanded="true">
							<span class="nav-label">About</span> <span class="caret"></span>
						</a>
						<ul class="dropdown-menu" aria-labelledby="navbarDropdownAbout">
							<li><a href="#" id="about_references" class="dropdown-item"></a></li>
						</ul>
					</li>


				</ul>
				<!-- END: MENU CONTENT -->

			</div>
		</nav>
        <!-- END: Header -->
		<span id="main"></span>
`;

replaceElementWithContent("pageHeader", pageHead);

