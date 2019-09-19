const path = require('path');
module.exports = {
    entry: './wwwroot/js/main.js',
    output: {
        path: path.resolve(__dirname, 'wwwroot/dev-dist'),
        filename: 'bundle.js',
        libraryTarget: 'var',
        library: 'app'
    }
};