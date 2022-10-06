export class Settings {
    public static headers:any = {
        headers: {
            Authorization: 'Bearer ' + sessionStorage.getItem('PURC_delivery_report_token'),
            'Content-Type': 'application/json'
        }
    }

    public static IMG_GAROON: string = `http://cptsvs522/cbgrn/grn/image/customimg/emp_pic/${sessionStorage.getItem('PURC_delivery_report_username')}`;
}