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
				<ul class="navbar-nav mr-auto">


					<li class="nav-item dropdown">
						<a class="nav-link dropdown-toggle" href="#" id="navbarDropdownAbout" data-toggle="dropdown" aria-haspopup="true" aria-expanded="false">
							Installation
						</a>
						<div class="dropdown-menu" aria-labelledby="navbarDropdownAbout">
							<a id="installation_install" class="dropdown-item"></a>
							<a id="installation_update" class="dropdown-item"></a>
							<a id="installation_afterupdate" class="dropdown-item"></a>
							<a id="installation_initialconfig" class="dropdown-item"></a>
						</div>
					</li>


					<li class="nav-item dropdown">
						<a class="nav-link dropdown-toggle" href="#" id="navbarDropdownAbout" data-toggle="dropdown" aria-haspopup="true" aria-expanded="false">
							Remote
						</a>
						<div class="dropdown-menu" aria-labelledby="navbarDropdownAbout">
							<a id="remote_terminal" class="dropdown-item"></a>
							<a id="remote_filetransfer" class="dropdown-item"></a>
						</div>
					</li>


					<li class="nav-item dropdown">
						<a class="nav-link dropdown-toggle" href="#" id="navbarDropdownAbout" data-toggle="dropdown" aria-haspopup="true" aria-expanded="false">
							Phones
						</a>
						<div class="dropdown-menu" aria-labelledby="navbarDropdownAbout">
							<a id="phones_linphone" class="dropdown-item"></a>
							<a id="phones_pots" class="dropdown-item"></a>
							<a id="phones_cisco79xx" class="dropdown-item"></a>
						</div>
					</li>


					<li class="nav-item dropdown">
						<a class="nav-link dropdown-toggle" href="#" id="navbarDropdownAbout" data-toggle="dropdown" aria-haspopup="true" aria-expanded="false">
							About
						</a>
						<div class="dropdown-menu" aria-labelledby="navbarDropdownAbout">
							<a id="about_references" class="dropdown-item"></a>
						</div>
					</li>
				</ul>
				<!-- END: MENU CONTENT -->

			</div>
		</nav>
        <!-- END: Header -->
		<span id="main"></span>
`;

replaceElementWithContent("pageHeader", pageHead);