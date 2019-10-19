export default class Common {
    constructor() {
    }

    toggleMenu(e) {
        e.preventDefault();
        $('#adminSideMenu').slideToggle();
    }
}