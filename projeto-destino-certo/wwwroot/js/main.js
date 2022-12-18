//MENU ANIMATION

$(document).click(function () {
  $(".menu-hamburger").hide();
});

$("#button-hamburger").click(function (event) {
  event.stopPropagation();
  $(".menu-hamburger").slideToggle();
});

$(document).ready(() => {
  //SPLIDE CAROUSEL

  new Splide(".splide", {
    type: "loop",
    height: "30%",
    width: "100%",
    perPage: 4,
    focus: "center",
    pagination: false,
    breakpoints: {
      1100: {
        perPage: 2.5,
        height: "50%",
      },

      760: {
        height: "70%",
        perPage: 2,
      },
      510: {
        height: "80%",
        perPage: 1.5,
      },
    },
  }).mount();
});
