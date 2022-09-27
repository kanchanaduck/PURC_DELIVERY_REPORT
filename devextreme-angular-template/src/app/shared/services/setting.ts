export class Settings {
    public static headers:any = {
        headers: {
            Authorization: 'Bearer ' + sessionStorage.getItem('PURC_delivery_report_token'),
            'Content-Type': 'application/json'
        }
    }
}