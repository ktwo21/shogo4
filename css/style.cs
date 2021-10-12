@charset "UTF-8";
html {
  font-size: 62.5%; }

*, *::before, *::after {
  box-sizing: border-box; }

body {
  font-family: “Times New Roman”, “游明朝”, “Yu Mincho”, “游明朝体”, “YuMincho”, “ヒラギノ明朝 Pro W3”, “Hiragino Mincho Pro”, “HiraMinProN-W3”, “HGS明朝E”, “ＭＳ Ｐ明朝”, “MS PMincho”, serif; }

main {
  overflow: hidden; }

.title {
  text-align: center; }
  .title h2 {
    font-size: 3.6rem; }
    .title h2::before {
      content: url(../image/title-icon.svg);
      display: block;
      margin: 0 auto 13px;
      width: 40px;
      height: 40px;
      object-fit: contain; }
  @media (max-width: 425px) {
    .title h2 {
      font-size: calc(2.6rem + 10 * (100vw - 320px)/448); } }

.white-bg {
  position: absolute;
  display: none;
  width: 100vw;
  height: 100vh;
  background: rgba(255, 255, 255, 0.6);
  z-index: 1; }

@media (max-width: 425px) {
  .br-mobile {
    display: none; } }
.navigation {
  position: fixed;
  top: 0;
  z-index: 5;
  display: flex;
  align-items: center;
  justify-content: space-between;
  width: 100%;
  height: 80px;
  background: rgba(255, 255, 255, 0);
  transition: all 0.3s; }
  .navigation .header-navigation {
    display: flex;
    align-items: center; }
    .navigation .header-navigation h1 {
      margin-left: 20px;
      max-width: 200px;
      width: calc(150px + 50 * (100vw - 375px)/649);
      height: auto; }
      .navigation .header-navigation h1 img {
        width: 100%;
        height: auto;
        object-fit: contain;
        vertical-align: bottom; }
    .navigation .header-navigation ul {
      display: flex;
      align-items: center;
      margin-left: 120px;
      font-size: 1.6rem;
      white-space: nowrap; }
      .navigation .header-navigation ul li {
        margin-right: 33px;
        color: white; }
        .navigation .header-navigation ul li:last-of-type {
          margin-right: 0; }
  .navigation .navigation-right {
    display: flex;
    align-items: center; }
    .navigation .navigation-right .reserve-button {
      display: flex;
      align-items: center;
      justify-content: center;
      margin-right: 20px;
      padding: 0 20px;
      width: 100%;
      height: 54px;
      height: 54px;
      background: #978F10;
      color: white;
      font-size: 1.6rem; }
      .navigation .navigation-right .reserve-button img {
        width: 22px;
        height: 22px;
        object-fit: contain; }
      .navigation .navigation-right .reserve-button span {
        margin-left: 10px; }
        @media (max-width: 425px) {
          .navigation .navigation-right .reserve-button span {
            display: none; } }
    .navigation .navigation-right .hamburger-button {
      display: none;
      margin-right: 20px;
      width: 30px;
      height: 30px;
      cursor: pointer; }
      .navigation .navigation-right .hamburger-button .bar {
        position: relative;
        top: 50%;
        transform: translateY(-50%);
        display: block;
        width: 25px;
        height: 1px;
        background: white;
        transition: 1s; }
        .navigation .navigation-right .hamburger-button .bar::before, .navigation .navigation-right .hamburger-button .bar::after {
          position: absolute;
          display: block;
          content: "";
          width: 25px;
          height: 1px;
          background: white;
          transition: 1s; }
        .navigation .navigation-right .hamburger-button .bar::before {
          top: -1em; }
        .navigation .navigation-right .hamburger-button .bar::after {
          top: 1em; }
      .navigation .navigation-right .hamburger-button.open .bar {
        background: rgba(255, 255, 255, 0);
        transition: 1s; }
        .navigation .navigation-right .hamburger-button.open .bar::before, .navigation .navigation-right .hamburger-button.open .bar::after {
          top: 0;
          transition: 1s; }
        .navigation .navigation-right .hamburger-button.open .bar::before {
          transform: rotate(225deg); }
        .navigation .navigation-right .hamburger-button.open .bar::after {
          transform: rotate(-225deg); }
    .navigation .navigation-right .hamburger-menu {
      position: absolute;
      top: 0px;
      right: -500px;
      z-index: -1;
      width: 320px;
      height: 100vh;
      background: rgba(0, 0, 0, 0.7);
      transition: 1s; }
      .navigation .navigation-right .hamburger-menu ul {
        display: flex;
        align-items: center;
        flex-direction: column;
        justify-content: center;
        gap: 30px;
        padding: 200px 30px; }
        .navigation .navigation-right .hamburger-menu ul li {
          color: white;
          font-size: 1.6rem;
          line-height: calc(36/16); }
      .navigation .navigation-right .hamburger-menu.open {
        right: 0;
        transition: 1s; }
  @media (max-width: 768px) {
    .navigation .header-navigation ul {
      display: none; }
    .navigation .navigation-right .hamburger-button {
      display: block; } }

.navigation.under-page,
.navigation.scroll-navigation {
  background: white;
  transition: all 0.3s; }
  .navigation.under-page .header-navigation h1,
  .navigation.scroll-navigation .header-navigation h1 {
    background: url(../image/logo-black.svg) no-repeat center/contain; }
    .navigation.under-page .header-navigation h1 img,
    .navigation.scroll-navigation .header-navigation h1 img {
      opacity: 0; }
  .navigation.under-page .header-navigation ul li,
  .navigation.scroll-navigation .header-navigation ul li {
    color: #000; }
  .navigation.under-page .navigation-right .hamburger-button .bar,
  .navigation.scroll-navigation .navigation-right .hamburger-button .bar {
    background: #000; }
    .navigation.under-page .navigation-right .hamburger-button .bar::before, .navigation.under-page .navigation-right .hamburger-button .bar::after,
    .navigation.scroll-navigation .navigation-right .hamburger-button .bar::before,
    .navigation.scroll-navigation .navigation-right .hamburger-button .bar::after {
      background: #000; }

.modal {
  position: fixed;
  top: 50%;
  left: 50%;
  transform: translate(-50%, -50%);
  z-index: 2;
  display: none;
  border: 1px solid #707070;
  max-width: 550px;
  width: 90%;
  max-height: 600px;
  height: 90%;
  background: white; }

.close-button {
  position: absolute;
  top: 20px;
  right: 22px;
  display: flex;
  align-items: center;
  justify-content: center;
  width: 18px;
  height: 18px; }
  .close-button span {
    width: 18px;
    height: 1px;
    background: #000;
    transform: rotate(45deg); }
    .close-button span::after {
      content: "";
      display: block;
      width: 18px;
      height: 1px;
      background: #000;
      transform: rotate(-90deg); }

.modal .modal-title {
  margin-top: 25px;
  margin-bottom: 26px;
  font-size: 2rem;
  text-align: center; }

.modal form {
  margin: 0 auto;
  border-top: 1px solid #E7E7E7;
  padding: 33px 0 90px;
  max-width: 430px;
  width: 90%;
  text-align: center; }
  .modal form ul li {
    margin-bottom: 12px;
    text-align: left; }
    .modal form ul li:last-of-type {
      margin-bottom: 64px; }
    .modal form ul li p {
      margin-bottom: 5px;
      font-size: 1.6rem; }
      .modal form ul li p span {
        display: inline-block; }
    .modal form ul li input {
      border: 1px solid #E7E7E7;
      width: 100%;
      height: 32px; }
      .modal form ul li input[placeholder] {
        background: white;
        color: #797878;
        font-size: 1.4rem;
        line-height: 19px; }
    .modal form ul li select {
      background: white;
      border: 1px solid #E7E7E7;
      width: 100%;
      height: 32px; }

.modal form button {
  border: 1px solid #E7E7E7;
  width: 198px;
  height: 42px;
  background: white;
  font-size: 1.6rem;
  line-height: 42px; }

.hero-area {
  position: relative;
  width: 100vw;
  height: 100vh;
  overflow: hidden; }
  .hero-area .bgImg {
    position: absolute;
    top: 0;
    left: 0;
    bottom: 0;
    right: 0;
    animation: bgAnime 21s infinite;
    opacity: 0; }
  .hero-area .src1 {
    background: url(../image/mainbg01.jpg) no-repeat center/cover; }
  .hero-area .src2 {
    animation-delay: 7s;
    background: url(../image/mainbg02.jpg) no-repeat center/cover; }
  .hero-area .src3 {
    animation-delay: 14s;
    background: url(../image/mainbg03.jpg) no-repeat center/cover; }
@keyframes bgAnime {
  0% {
    opacity: 0;
    z-index: 1; }
  10% {
    opacity: 1; }
  30% {
    opacity: 1; }
  40% {
    opacity: 1; }
  100% {
    opacity: 0;
    transform: scale(1.1); } }
  .hero-area .copy {
    position: absolute;
    top: 50%;
    right: 24%;
    z-index: 2;
    transform: translate(-24%, -50%); }
    @media (max-width: 768px) {
      .hero-area .copy {
        right: 50%;
        transform: translate(50%, -50%); } }
    .hero-area .copy h1 {
      color: white;
      font-size: calc(2.5rem + 9 * (100vw - 375px)/1545);
      font-weight: 700;
      line-height: calc(82/34);
      letter-spacing: 0.3em;
      writing-mode: vertical-rl; }

.concept {
  display: flex;
  margin: 0 auto;
  padding: 146px 0 80px;
  width: 100%;
  background: url(../image/bg01.jpg) no-repeat center/cover;
  writing-mode: vertical-rl; }
  .concept .wrap {
    display: flex;
    flex-direction: column;
    justify-content: center;
    gap: 6vw;
    margin: 0 auto;
    max-width: 1180px;
    width: 90%; }
    .concept .wrap header h2 {
      font-size: 2.8rem;
      line-height: calc(60/28);
      letter-spacing: 0.5em;
      text-indent: -3em; }
    .concept .wrap .concept-text {
      display: flex;
      flex-direction: column;
      gap: 6vw; }
      .concept .wrap .concept-text p {
        font-size: 1.6rem;
        line-height: calc(44/16);
        letter-spacing: 0.5em;
        white-space: nowrap; }
        @media (max-width: 425px) {
          .concept .wrap .concept-text p {
            line-height: calc(28/16);
            white-space: unset; } }
        .concept .wrap .concept-text p:last-of-type {
          font-size: 2.2rem;
          line-height: calc(32/22);
          text-align: right; }
  @media (max-width: 768px) {
    .concept {
      padding: 80px 0;
      writing-mode: unset; }
      .concept .wrap header h2 {
        font-size: calc(2.2rem + 6 * (100vw - 320px)/448);
        text-indent: 0; }
      .concept .wrap .concenpt-text p {
        font-size: calc(1.4rem + 2 * (100vw - 320px)/448); } }

.menu {
  margin: 0 auto;
  padding: 106px 0 78px;
  max-width: 1180px;
  width: 90%; }
  .menu .layer-introduction {
    display: flex;
    align-items: center;
    justify-content: flex-start;
    gap: 7vw;
    margin-bottom: 122px; }
    .menu .layer-introduction:nth-of-type(even) {
      flex-direction: row-reverse; }
    .menu .layer-introduction:last-of-type {
      margin-bottom: 0; }
    .menu .layer-introduction img {
      max-width: 1050px;
      width: 54%;
      max-height: 545px;
      height: 28vw;
      object-fit: cover; }
    .menu .layer-introduction figcaption {
      max-width: 295px;
      padding-top: 35px; }
      .menu .layer-introduction figcaption h2 {
        margin-bottom: 1em;
        font-size: calc(2.5rem + 11 * (100vw - 1280px)/640);
        line-height: calc(62/36); }
      .menu .layer-introduction figcaption p {
        margin-bottom: 3em;
        font-size: max(calc(1.4rem + 2 * (100vw - 1280px)/640), 1.4rem);
        line-height: calc(32/16); }
      .menu .layer-introduction figcaption .to-layer {
        border: 1px solid #707070;
        width: 200px;
        height: 56px;
        text-align: center;
        transition: all 0.3s; }
        .menu .layer-introduction figcaption .to-layer a {
          width: 100%;
          font-size: 1.6rem;
          line-height: 56px; }
        .menu .layer-introduction figcaption .to-layer:hover {
          background: #978F10;
          transition: all 0.3s; }
          .menu .layer-introduction figcaption .to-layer:hover a {
            color: white; }
  @media (max-width: 767px) {
    .menu .layer-introduction {
      gap: 1em;
      flex-direction: column;
      margin-bottom: 80px; }
      .menu .layer-introduction:nth-of-type(even) {
        flex-direction: column; }
      .menu .layer-introduction img {
        width: 90%;
        max-height: unset;
        height: auto; }
      .menu .layer-introduction figcaption {
        padding: 15px;
        max-width: 1050px;
        width: 90%; }
        .menu .layer-introduction figcaption h2 {
          font-size: calc(1.8rem + 7 * (100vw - 320px)/448); }
        .menu .layer-introduction figcaption p {
          margin-bottom: 2em; } }

.plan {
  margin: 0 auto;
  padding: 60px 0 142px;
  background: url(../image/bg02.jpg) no-repeat center/cover; }
  .plan .title {
    margin-bottom: 61px; }
  .plan .item {
    display: flex;
    justify-content: center;
    gap: 4vw;
    margin: 0 auto;
    max-widht: 1180px;
    width: 90%; }
    .plan .item figure {
      width: 331px; }
      .plan .item figure img {
        width: 100%;
        height: 209px;
        object-fit: cover; }
      .plan .item figure figcaption {
        padding-top: 28px; }
        .plan .item figure figcaption h3 {
          margin-bottom: 1em;
          font-size: 2rem;
          line-height: calc(32/20); }
        .plan .item figure figcaption .item-text {
          font-size: max(calc(1.4rem + 2 * (100vw - 1280px)/640), 1.4rem);
          line-height: calc(32/16); }
    @media (max-width: 1179px) {
      .plan .item {
        align-items: center;
        flex-direction: column; }
        .plan .item figure {
          width: 90%; }
          .plan .item figure img {
            height: auto; }
          .plan .item figure figcaption {
            padding: 15px; }
            .plan .item figure figcaption h3 {
              font-size: calc(1.8rem + 7 * (100vw - 320px)/860); }
            .plan .item figure figcaption .item-text {
              margin-bottom: 2em; } }
  @media (max-width: 768px) {
    .plan {
      padding: 80px 0; } }

.news {
  padding: 60px 0; }
  .news header {
    margin-bottom: 38px; }
  .news .tab-list {
    margin-bottom: 47px; }
    .news .tab-list ul {
      display: flex;
      justify-content: center;
      gap: 53px;
      font-size: 1.6rem;
      line-height: calc(32/16); }
      .news .tab-list ul li {
        cursor: pointer; }
      .news .tab-list ul .focus {
        text-decoration: underline; }
  .news .card-list {
    display: flex;
    justify-content: center; }
    .news .card-list .items {
      display: none;
      flex-wrap: wrap;
      flex-direction: column;
      justify-content: center;
      gap: 20px 40px;
      max-width: 1180px;
      width: 90%;
      height: 430px;
      opacity: 0; }
      .news .card-list .items.active {
        display: flex;
        opacity: 1;
        animation-duration: 1s;
        animation-name: fade-in; }
@keyframes fade-in {
  0% {
    display: none;
    opacity: 0; }
  1% {
    display: block;
    opacity: 0; }
  100% {
    display: block;
    opacity: 1; } }
      .news .card-list .items .news-card {
        display: flex;
        gap: 30px;
        padding: 15px 10px;
        max-width: 570px;
        width: 50%;
        background: #F6F6F6; }
        .news .card-list .items .news-card .card-image {
          width: 103px;
          height: 100px; }
          .news .card-list .items .news-card .card-image img {
            width: 103px;
            height: 100%;
            object-fit: cover; }
        .news .card-list .items .news-card .card-text {
          width: 320px; }
          .news .card-list .items .news-card .card-text time {
            font-size: 1.4rem;
            line-height: calc(32/14); }
          .news .card-list .items .news-card .card-text p {
            font-size: 1.6rem;
            line-height: calc(32/16); }
      @media (max-width: 1179px) {
        .news .card-list .items {
          align-items: center;
          flex-wrap: nowrap;
          justify-content: unset;
          height: unset; }
          .news .card-list .items .news-card {
            align-items: center;
            width: 100%; } }

.access {
  margin: 0 auto;
  padding: 60px 0 110px;
  background: url(../image/bg01.jpg) no-repeat center/cover; }
  .access .title {
    margin-bottom: 79px; }
  .access figure {
    display: flex;
    align-items: center;
    justify-content: center;
    gap: 4vw;
    margin-bottom: 69px; }
    .access figure img {
      max-width: 656px;
      width: 34vw;
      min-width: 370px;
      max-height: 370px;
      height: 100%;
      object-fit: cover; }
    .access figure figcaption {
      max-width: 569px;
      width: 30vw;
      font-size: 1.6rem;
      line-height: calc(32/16); }
      .access figure figcaption dt {
        margin-bottom: 19px;
        font-weight: bold; }
      .access figure figcaption dd {
        margin-bottom: 19px; }
  .access .map {
    margin: 0 auto;
    max-width: 792px;
    width: 100%; }
    .access .map iframe {
      max-width: 792px;
      width: 100%;
      height: 592px; }
  @media (max-width: 768px) {
    .access {
      padding: 80px 0; }
      .access figure {
        flex-direction: column; }
        .access figure img {
          display: none; }
        .access figure figcaption {
          padding: 20px;
          max-width: 656px;
          width: 90%;
          background: url(../image/acess.jpg) no-repeat center/cover;
          background-blend-mode: lighten;
          color: white; }
          .access figure figcaption dt {
            margin-bottom: 0; }
          .access figure figcaption p {
            margin-left: 1em;
            text-indent: -1em; }
      .access .map {
        width: 90%; }
        .access .map iframe {
          height: 50vw; } }

footer {
  margin: 0 auto;
  padding-top: 61px;
  background: url(../image/bg03.jpg); }
  footer nav {
    margin-bottom: 93px; }
    footer nav ul {
      display: flex;
      flex-direction: column;
      justify-content: center;
      gap: 34px;
      margin: 0 auto;
      font-size: 1.8rem;
      line-height: calc(32/18);
      letter-spacing: 0.3em;
      writing-mode: vertical-rl; }
  footer .infomation {
    padding-bottom: 59px; }
    footer .infomation .footer-logo {
      margin: 0 auto 65px;
      width: 145px;
      height: 96px; }
      footer .infomation .footer-logo img {
        width: 100%;
        height: 100%;
        object-fit: contain; }
    footer .infomation .footer-address {
      text-align: center; }
      footer .infomation .footer-address p {
        font-size: 1.6rem;
        line-height: calc(48/16); }
        footer .infomation .footer-address p span {
          margin-right: 16px; }
        footer .infomation .footer-address p:last-of-type span {
          margin-right: 21px; }
  footer .copyright {
    width: 100%;
    height: 60px;
    background: #000;
    text-align: center; }
    footer .copyright small {
      color: white;
      font-size: 1.2rem;
      line-height: 60px; }

.hero-area_under {
  position: relative;
  margin-top: 80px;
  width: 100%;
  max-height: 500px;
  height: 90vh; }
  .hero-area_under h2 {
    position: absolute;
    top: 50%;
    left: 50%;
    transform: translate(-50%, -50%);
    color: white;
    font-size: 3.4rem;
    font-weight: 800; }

.food {
  background: url(../image/menu-top.jpg) no-repeat center/cover; }

.room {
  background: url(../image/oheya-top.jpg) no-repeat center/cover; }

.onsen {
  background: url(../image/onsen-top.jpg) no-repeat center/cover; }

.breadcrumbs {
  margin: 0 auto;
  padding-top: 33px;
  max-width: 1180px;
  width: 100%; }
  .breadcrumbs ol {
    display: flex; }
    .breadcrumbs ol li {
      display: flex;
      font-size: 1.6rem; }
      .breadcrumbs ol li::after {
        content: "\03e";
        display: block;
        margin: 0 1em; }
      .breadcrumbs ol li:last-of-type::after {
        display: none; }

.main-area {
  margin: 0 auto;
  padding: 69px 0; }
  .main-area .page-description {
    margin-bottom: 133px;
    font-size: 1.6rem;
    line-height: calc(32/16);
    text-align: center; }
  .main-area figure {
    display: flex;
    justify-content: center;
    margin: 0 auto 141px;
    max-width: 1180px;
    width: 100%; }
    .main-area figure:nth-of-type(3) {
      margin-bottom: 150px; }
    .main-area figure img {
      margin-top: -52px;
      width: 525px;
      height: 300px;
      object-fit: cover;
      z-index: 1; }
    .main-area figure figcaption {
      margin-left: -158px;
      padding: 55px 0 0 238px;
      width: 813px;
      height: 381px;
      background: url(../image/bg01.jpg) no-repeat center/cover; }
      .main-area figure figcaption h3 {
        margin-bottom: 2em;
        font-size: 2.4rem;
        line-height: calc(32/24); }
      .main-area figure figcaption .text p {
        margin-bottom: 3rem;
        font-size: 1.6rem;
        line-height: calc(32/16); }
      .main-area figure figcaption .text li {
        display: flex;
        font-size: 1.4rem;
        line-height: calc(21/14); }
        .main-area figure figcaption .text li::before {
          content: "＊";
          display: block; }
    .main-area figure:nth-of-type(even) {
      flex-direction: row-reverse; }
      .main-area figure:nth-of-type(even) figcaption {
        margin-left: 0;
        margin-right: -158px;
        padding: 55px 0 238px 60px; }
  .main-area .efficacy {
    margin: 0 auto 96px;
    border-top: 1px solid #E7E7E7;
    border-bottom: 1px solid #E7E7E7;
    padding: 90px 0 74px;
    max-width: 1180px;
    width: 100%; }
    .main-area .efficacy h4 {
      margin-bottom: 47px;
      font-size: 2.6rem;
      line-height: calc(32/26);
      text-align: center; }
    .main-area .efficacy dl {
      margin: 0 auto;
      width: 880px; }
      .main-area .efficacy dl .list {
        padding: 15px 0;
        display: flex;
        align-items: center;
        border-top: 1px solid #E7E7E7;
        font-size: 1.5rem;
        line-height: calc(22/15); }
        .main-area .efficacy dl .list dt {
          width: 220px; }
        .main-area .efficacy dl .list dd {
          width: 660px; }
        .main-area .efficacy dl .list:last-of-type {
          border-bottom: 1px solid #E7E7E7; }

/*# sourceMappingURL=style.cs.map */
