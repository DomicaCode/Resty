const path = require('path');
module.exports = {
    entry: './wwwroot/js/main.js',
    output: {
        path: path.resolve(__dirname, 'wwwroot/dev-dist'),
        filename: 'app.js',
        libraryTarget: 'var',
        library: 'app'
    }
};