export default class OrderHub {
    constructor() {
        this.initialize();
    }

    async initialize() {
        this.connection = new signalR.HubConnectionBuilder()
            .withUrl('/orderHub')
            .build();

        await this.connection.start();
    }
}