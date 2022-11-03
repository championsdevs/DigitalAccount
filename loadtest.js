import http from 'k6/http';

export const options = {
    vus: 10,
    duration: '60s',
    thresholds: {
        http_req_failed: ['rate<0.01'], // http errors should be less than 1%
        http_req_duration: ['p(95)<200'], // 95% of requests should be below 200ms
    },
};

export default function () {
    let data = {
        name: 'maria',
        email: 'maria@gmail.com',
        document: '79267537008'
    };

    http.post('https://localhost:7213/api/addcustomer', JSON.stringify(data), {
        headers: { 'Content-Type': 'application/json' }
    });
}