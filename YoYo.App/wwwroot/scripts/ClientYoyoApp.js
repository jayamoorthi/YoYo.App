const API_BASE_URL = 'http://localhost:56648/api/';

const jsonData = [
    {
        "AccumulatedShuttleDistance": "40",
        "SpeedLevel": "5",
        "ShuttleNo": "1",
        "Speed": "10",
        "LevelTime": "14.4",
        "CommulativeTime": "00:24",
        "StartTime": "00:00",
        "ApproxVo2Max": "36.74"
    },
    {
        "AccumulatedShuttleDistance": "80",
        "SpeedLevel": "9",
        "ShuttleNo": "1",
        "Speed": "12",
        "LevelTime": "12.5",
        "CommulativeTime": "00:46",
        "StartTime": "00:25",
        "ApproxVo2Max": "37.07"
    },
    {
        "AccumulatedShuttleDistance": "120",
        "SpeedLevel": "11",
        "ShuttleNo": "1",
        "Speed": "13",
        "LevelTime": "11.1",
        "CommulativeTime": "01:07",
        "StartTime": "00:47",
        "ApproxVo2Max": "37.41"
    },
    {
        "AccumulatedShuttleDistance": "160",
        "SpeedLevel": "11",
        "ShuttleNo": "2",
        "Speed": "13",
        "LevelTime": "11.1",
        "CommulativeTime": "01:29",
        "StartTime": "01:08",
        "ApproxVo2Max": "37.74"
    },
    {
        "AccumulatedShuttleDistance": "200",
        "SpeedLevel": "12",
        "ShuttleNo": "1",
        "Speed": "13.5",
        "LevelTime": "10.7",
        "CommulativeTime": "01:49",
        "StartTime": "01:30",
        "ApproxVo2Max": "38.08"
    },
    {
        "AccumulatedShuttleDistance": "240",
        "SpeedLevel": "12",
        "ShuttleNo": "2",
        "Speed": "13.5",
        "LevelTime": "10.7",
        "CommulativeTime": "02:10",
        "StartTime": "01:50",
        "ApproxVo2Max": "38.42"
    },
    {
        "AccumulatedShuttleDistance": "280",
        "SpeedLevel": "12",
        "ShuttleNo": "3",
        "Speed": "13.5",
        "LevelTime": "10.7",
        "CommulativeTime": "02:31",
        "StartTime": "02:11",
        "ApproxVo2Max": "38.75"
    },
    {
        "AccumulatedShuttleDistance": "320",
        "SpeedLevel": "13",
        "ShuttleNo": "1",
        "Speed": "14",
        "LevelTime": "10.3",
        "CommulativeTime": "02:51",
        "StartTime": "02:32",
        "ApproxVo2Max": "39.09"
    },
    {
        "AccumulatedShuttleDistance": "360",
        "SpeedLevel": "13",
        "ShuttleNo": "2",
        "Speed": "14",
        "LevelTime": "10.3",
        "CommulativeTime": "03:11",
        "StartTime": "02:52",
        "ApproxVo2Max": "39.42"
    },
    {
        "AccumulatedShuttleDistance": "400",
        "SpeedLevel": "13",
        "ShuttleNo": "3",
        "Speed": "14",
        "LevelTime": "10.3",
        "CommulativeTime": "03:31",
        "StartTime": "03:12",
        "ApproxVo2Max": "39.76"
    },
    {
        "AccumulatedShuttleDistance": "440",
        "SpeedLevel": "13",
        "ShuttleNo": "4",
        "Speed": "14",
        "LevelTime": "10.3",
        "CommulativeTime": "03:52",
        "StartTime": "03:32",
        "ApproxVo2Max": "40.10"
    },
    {
        "AccumulatedShuttleDistance": "480",
        "SpeedLevel": "14",
        "ShuttleNo": "1",
        "Speed": "14.5",
        "LevelTime": "9.9",
        "CommulativeTime": "04:12",
        "StartTime": "03:53",
        "ApproxVo2Max": "40.43"
    },
    {
        "AccumulatedShuttleDistance": "520",
        "SpeedLevel": "14",
        "ShuttleNo": "2",
        "Speed": "14.5",
        "LevelTime": "9.9",
        "CommulativeTime": "04:32",
        "StartTime": "04:12",
        "ApproxVo2Max": "40.77"
    },
    {
        "AccumulatedShuttleDistance": "560",
        "SpeedLevel": "14",
        "ShuttleNo": "3",
        "Speed": "14.5",
        "LevelTime": "9.9",
        "CommulativeTime": "04:51",
        "StartTime": "04:33",
        "ApproxVo2Max": "41.10"
    },
    {
        "AccumulatedShuttleDistance": "600",
        "SpeedLevel": "14",
        "ShuttleNo": "4",
        "Speed": "14.5",
        "LevelTime": "9.9",
        "CommulativeTime": "05:11",
        "StartTime": "04:52",
        "ApproxVo2Max": "41.44"
    },
    {
        "AccumulatedShuttleDistance": "640",
        "SpeedLevel": "14",
        "ShuttleNo": "5",
        "Speed": "14.5",
        "LevelTime": "9.9",
        "CommulativeTime": "05:31",
        "StartTime": "05:12",
        "ApproxVo2Max": "41.78"
    },
    {
        "AccumulatedShuttleDistance": "680",
        "SpeedLevel": "14",
        "ShuttleNo": "6",
        "Speed": "14.5",
        "LevelTime": "9.9",
        "CommulativeTime": "05:51",
        "StartTime": "05:32",
        "ApproxVo2Max": "42.11"
    },
    {
        "AccumulatedShuttleDistance": "720",
        "SpeedLevel": "14",
        "ShuttleNo": "7",
        "Speed": "14.5",
        "LevelTime": "9.9",
        "CommulativeTime": "06:11",
        "StartTime": "05:52",
        "ApproxVo2Max": "42.45"
    },
    {
        "AccumulatedShuttleDistance": "760",
        "SpeedLevel": "14",
        "ShuttleNo": "8",
        "Speed": "14.5",
        "LevelTime": "9.9",
        "CommulativeTime": "06:31",
        "StartTime": "06:12",
        "ApproxVo2Max": "42.78"
    },
    {
        "AccumulatedShuttleDistance": "800",
        "SpeedLevel": "15",
        "ShuttleNo": "1",
        "Speed": "15",
        "LevelTime": "9.6",
        "CommulativeTime": "06:51",
        "StartTime": "06:32",
        "ApproxVo2Max": "43.12"
    },
    {
        "AccumulatedShuttleDistance": "840",
        "SpeedLevel": "15",
        "ShuttleNo": "2",
        "Speed": "15",
        "LevelTime": "9.6",
        "CommulativeTime": "07:10",
        "StartTime": "06:52",
        "ApproxVo2Max": "43.46"
    },
    {
        "AccumulatedShuttleDistance": "880",
        "SpeedLevel": "15",
        "ShuttleNo": "3",
        "Speed": "15",
        "LevelTime": "9.6",
        "CommulativeTime": "07:30",
        "StartTime": "07:11",
        "ApproxVo2Max": "43.79"
    },
    {
        "AccumulatedShuttleDistance": "920",
        "SpeedLevel": "15",
        "ShuttleNo": "4",
        "Speed": "15",
        "LevelTime": "9.6",
        "CommulativeTime": "07:50",
        "StartTime": "07:31",
        "ApproxVo2Max": "44.13"
    },
    {
        "AccumulatedShuttleDistance": "960",
        "SpeedLevel": "15",
        "ShuttleNo": "5",
        "Speed": "15",
        "LevelTime": "9.6",
        "CommulativeTime": "08:09",
        "StartTime": "07:51",
        "ApproxVo2Max": "44.40"
    },
    {
        "AccumulatedShuttleDistance": "1000",
        "SpeedLevel": "15",
        "ShuttleNo": "6",
        "Speed": "15",
        "LevelTime": "9.6",
        "CommulativeTime": "08:29",
        "StartTime": "08:10",
        "ApproxVo2Max": "44.80"
    },
    {
        "AccumulatedShuttleDistance": "1040",
        "SpeedLevel": "15",
        "ShuttleNo": "7",
        "Speed": "15",
        "LevelTime": "9.6",
        "CommulativeTime": "08:48",
        "StartTime": "08:30",
        "ApproxVo2Max": "45.14"
    },
    {
        "AccumulatedShuttleDistance": "1080",
        "SpeedLevel": "15",
        "ShuttleNo": "8",
        "Speed": "15",
        "LevelTime": "9.6",
        "CommulativeTime": "09:08",
        "StartTime": "08:49",
        "ApproxVo2Max": "45.47"
    },
    {
        "AccumulatedShuttleDistance": "1120",
        "SpeedLevel": "16",
        "ShuttleNo": "1",
        "Speed": "15.5",
        "LevelTime": "9.3",
        "CommulativeTime": "09:27",
        "StartTime": "09:09",
        "ApproxVo2Max": "45.81"
    },
    {
        "AccumulatedShuttleDistance": "1160",
        "SpeedLevel": "16",
        "ShuttleNo": "2",
        "Speed": "15.5",
        "LevelTime": "9.3",
        "CommulativeTime": "09:47",
        "StartTime": "09:28",
        "ApproxVo2Max": "46.14"
    },
    {
        "AccumulatedShuttleDistance": "1200",
        "SpeedLevel": "16",
        "ShuttleNo": "3",
        "Speed": "15.5",
        "LevelTime": "9.3",
        "CommulativeTime": "10:06",
        "StartTime": "09:48",
        "ApproxVo2Max": "46.48"
    },
    {
        "AccumulatedShuttleDistance": "1240",
        "SpeedLevel": "16",
        "ShuttleNo": "4",
        "Speed": "15.5",
        "LevelTime": "9.3",
        "CommulativeTime": "10:25",
        "StartTime": "10:07",
        "ApproxVo2Max": "46.82"
    },
    {
        "AccumulatedShuttleDistance": "1280",
        "SpeedLevel": "16",
        "ShuttleNo": "5",
        "Speed": "15.5",
        "LevelTime": "9.3",
        "CommulativeTime": "10:44",
        "StartTime": "10:26",
        "ApproxVo2Max": "47.15"
    },
    {
        "AccumulatedShuttleDistance": "1320",
        "SpeedLevel": "16",
        "ShuttleNo": "6",
        "Speed": "15.5",
        "LevelTime": "9.3",
        "CommulativeTime": "11:04",
        "StartTime": "10:45",
        "ApproxVo2Max": "47.49"
    },
    {
        "AccumulatedShuttleDistance": "1360",
        "SpeedLevel": "16",
        "ShuttleNo": "7",
        "Speed": "15.5",
        "LevelTime": "9.3",
        "CommulativeTime": "11:23",
        "StartTime": "11:05",
        "ApproxVo2Max": "47.82"
    },
    {
        "AccumulatedShuttleDistance": "1400",
        "SpeedLevel": "16",
        "ShuttleNo": "8",
        "Speed": "15.5",
        "LevelTime": "9.3",
        "CommulativeTime": "11:42",
        "StartTime": "11:24",
        "ApproxVo2Max": "48.16"
    },
    {
        "AccumulatedShuttleDistance": "1440",
        "SpeedLevel": "17",
        "ShuttleNo": "1",
        "Speed": "16",
        "LevelTime": "9",
        "CommulativeTime": "12:01",
        "StartTime": "11:43",
        "ApproxVo2Max": "48.50"
    },
    {
        "AccumulatedShuttleDistance": "1480",
        "SpeedLevel": "17",
        "ShuttleNo": "2",
        "Speed": "16",
        "LevelTime": "9",
        "CommulativeTime": "12:20",
        "StartTime": "12:02",
        "ApproxVo2Max": "48.83"
    },
    {
        "AccumulatedShuttleDistance": "1520",
        "SpeedLevel": "17",
        "ShuttleNo": "3",
        "Speed": "16",
        "LevelTime": "9",
        "CommulativeTime": "12:39",
        "StartTime": "12:21",
        "ApproxVo2Max": "49.17"
    },
    {
        "AccumulatedShuttleDistance": "1560",
        "SpeedLevel": "17",
        "ShuttleNo": "4",
        "Speed": "16",
        "LevelTime": "9",
        "CommulativeTime": "12:58",
        "StartTime": "12:40",
        "ApproxVo2Max": "49.50"
    },
    {
        "AccumulatedShuttleDistance": "1600",
        "SpeedLevel": "17",
        "ShuttleNo": "5",
        "Speed": "16",
        "LevelTime": "9",
        "CommulativeTime": "13:17",
        "StartTime": "12:59",
        "ApproxVo2Max": "49.84"
    },
    {
        "AccumulatedShuttleDistance": "1640",
        "SpeedLevel": "17",
        "ShuttleNo": "6",
        "Speed": "16",
        "LevelTime": "9",
        "CommulativeTime": "13:36",
        "StartTime": "13:18",
        "ApproxVo2Max": "50.18"
    },
    {
        "AccumulatedShuttleDistance": "1680",
        "SpeedLevel": "17",
        "ShuttleNo": "7",
        "Speed": "16",
        "LevelTime": "9",
        "CommulativeTime": "13:55",
        "StartTime": "13:37",
        "ApproxVo2Max": "50.51"
    },
    {
        "AccumulatedShuttleDistance": "1720",
        "SpeedLevel": "17",
        "ShuttleNo": "8",
        "Speed": "16",
        "LevelTime": "9",
        "CommulativeTime": "14:14",
        "StartTime": "13:56",
        "ApproxVo2Max": "50.85"
    },
    {
        "AccumulatedShuttleDistance": "1760",
        "SpeedLevel": "18",
        "ShuttleNo": "1",
        "Speed": "16.5",
        "LevelTime": "8.7",
        "CommulativeTime": "14:33",
        "StartTime": "14:15",
        "ApproxVo2Max": "51.18"
    },
    {
        "AccumulatedShuttleDistance": "1800",
        "SpeedLevel": "18",
        "ShuttleNo": "2",
        "Speed": "16.5",
        "LevelTime": "8.7",
        "CommulativeTime": "14:52",
        "StartTime": "14:34",
        "ApproxVo2Max": "51.52"
    },
    {
        "AccumulatedShuttleDistance": "1840",
        "SpeedLevel": "18",
        "ShuttleNo": "3",
        "Speed": "16.5",
        "LevelTime": "8.7",
        "CommulativeTime": "15:10",
        "StartTime": "14:53",
        "ApproxVo2Max": "51.86"
    },
    {
        "AccumulatedShuttleDistance": "1880",
        "SpeedLevel": "18",
        "ShuttleNo": "4",
        "Speed": "16.5",
        "LevelTime": "8.7",
        "CommulativeTime": "15:29",
        "StartTime": "15:11",
        "ApproxVo2Max": "52.19"
    },
    {
        "AccumulatedShuttleDistance": "1920",
        "SpeedLevel": "18",
        "ShuttleNo": "5",
        "Speed": "16.5",
        "LevelTime": "8.7",
        "CommulativeTime": "15:48",
        "StartTime": "15:30",
        "ApproxVo2Max": "52.53"
    },
    {
        "AccumulatedShuttleDistance": "1960",
        "SpeedLevel": "18",
        "ShuttleNo": "6",
        "Speed": "16.5",
        "LevelTime": "8.7",
        "CommulativeTime": "16:07",
        "StartTime": "15:49",
        "ApproxVo2Max": "52.86"
    },
    {
        "AccumulatedShuttleDistance": "2000",
        "SpeedLevel": "18",
        "ShuttleNo": "7",
        "Speed": "16.5",
        "LevelTime": "8.7",
        "CommulativeTime": "16:25",
        "StartTime": "16:08",
        "ApproxVo2Max": "53.20"
    },
    {
        "AccumulatedShuttleDistance": "2040",
        "SpeedLevel": "18",
        "ShuttleNo": "8",
        "Speed": "16.5",
        "LevelTime": "8.7",
        "CommulativeTime": "16:44",
        "StartTime": "16:26",
        "ApproxVo2Max": "53.54"
    },
    {
        "AccumulatedShuttleDistance": "2080",
        "SpeedLevel": "19",
        "ShuttleNo": "1",
        "Speed": "17",
        "LevelTime": "8.5",
        "CommulativeTime": "17:03",
        "StartTime": "16:45",
        "ApproxVo2Max": "53.87"
    },
    {
        "AccumulatedShuttleDistance": "2120",
        "SpeedLevel": "19",
        "ShuttleNo": "2",
        "Speed": "17",
        "LevelTime": "8.5",
        "CommulativeTime": "17:21",
        "StartTime": "17:04",
        "ApproxVo2Max": "54.21"
    },
    {
        "AccumulatedShuttleDistance": "2160",
        "SpeedLevel": "19",
        "ShuttleNo": "3",
        "Speed": "17",
        "LevelTime": "8.5",
        "CommulativeTime": "17:39",
        "StartTime": "17:22",
        "ApproxVo2Max": "54.54"
    },
    {
        "AccumulatedShuttleDistance": "2200",
        "SpeedLevel": "19",
        "ShuttleNo": "4",
        "Speed": "17",
        "LevelTime": "8.5",
        "CommulativeTime": "17:58",
        "StartTime": "17:40",
        "ApproxVo2Max": "54.88"
    },
    {
        "AccumulatedShuttleDistance": "2240",
        "SpeedLevel": "19",
        "ShuttleNo": "5",
        "Speed": "17",
        "LevelTime": "8.5",
        "CommulativeTime": "18:16",
        "StartTime": "17:59",
        "ApproxVo2Max": "55.22"
    },
    {
        "AccumulatedShuttleDistance": "2280",
        "SpeedLevel": "19",
        "ShuttleNo": "6",
        "Speed": "17",
        "LevelTime": "8.5",
        "CommulativeTime": "18:35",
        "StartTime": "18:17",
        "ApproxVo2Max": "55.55"
    },
    {
        "AccumulatedShuttleDistance": "2320",
        "SpeedLevel": "19",
        "ShuttleNo": "7",
        "Speed": "17",
        "LevelTime": "8.5",
        "CommulativeTime": "18:53",
        "StartTime": "18:36",
        "ApproxVo2Max": "55.89"
    },
    {
        "AccumulatedShuttleDistance": "2360",
        "SpeedLevel": "19",
        "ShuttleNo": "8",
        "Speed": "17",
        "LevelTime": "8.5",
        "CommulativeTime": "19:12",
        "StartTime": "18:54",
        "ApproxVo2Max": "56.22"
    },
    {
        "AccumulatedShuttleDistance": "2400",
        "SpeedLevel": "20",
        "ShuttleNo": "1",
        "Speed": "17.5",
        "LevelTime": "8.2",
        "CommulativeTime": "19:30",
        "StartTime": "19:13",
        "ApproxVo2Max": "56.56"
    },
    {
        "AccumulatedShuttleDistance": "2440",
        "SpeedLevel": "20",
        "ShuttleNo": "2",
        "Speed": "17.5",
        "LevelTime": "8.2",
        "CommulativeTime": "19:48",
        "StartTime": "19:31",
        "ApproxVo2Max": "56.90"
    },
    {
        "AccumulatedShuttleDistance": "2480",
        "SpeedLevel": "20",
        "ShuttleNo": "3",
        "Speed": "17.5",
        "LevelTime": "8.2",
        "CommulativeTime": "20:07",
        "StartTime": "19:49",
        "ApproxVo2Max": "57.23"
    },
    {
        "AccumulatedShuttleDistance": "2520",
        "SpeedLevel": "20",
        "ShuttleNo": "4",
        "Speed": "17.5",
        "LevelTime": "8.2",
        "CommulativeTime": "20:25",
        "StartTime": "20:08",
        "ApproxVo2Max": "57.57"
    },
    {
        "AccumulatedShuttleDistance": "2560",
        "SpeedLevel": "20",
        "ShuttleNo": "5",
        "Speed": "17.5",
        "LevelTime": "8.2",
        "CommulativeTime": "20:43",
        "StartTime": "20:26",
        "ApproxVo2Max": "57.90"
    },
    {
        "AccumulatedShuttleDistance": "2600",
        "SpeedLevel": "20",
        "ShuttleNo": "6",
        "Speed": "17.5",
        "LevelTime": "8.2",
        "CommulativeTime": "21:01",
        "StartTime": "20:44",
        "ApproxVo2Max": "58.24"
    },
    {
        "AccumulatedShuttleDistance": "2640",
        "SpeedLevel": "20",
        "ShuttleNo": "7",
        "Speed": "17.5",
        "LevelTime": "8.2",
        "CommulativeTime": "21:19",
        "StartTime": "21:02",
        "ApproxVo2Max": "58.58"
    },
    {
        "AccumulatedShuttleDistance": "2680",
        "SpeedLevel": "20",
        "ShuttleNo": "8",
        "Speed": "17.5",
        "LevelTime": "8.2",
        "CommulativeTime": "21:38",
        "StartTime": "21:20",
        "ApproxVo2Max": "58.91"
    },
    {
        "AccumulatedShuttleDistance": "2720",
        "SpeedLevel": "21",
        "ShuttleNo": "1",
        "Speed": "18",
        "LevelTime": "8.0",
        "CommulativeTime": "21:56",
        "StartTime": "21:39",
        "ApproxVo2Max": "59.25"
    },
    {
        "AccumulatedShuttleDistance": "2760",
        "SpeedLevel": "21",
        "ShuttleNo": "2",
        "Speed": "18",
        "LevelTime": "8.0",
        "CommulativeTime": "22:14",
        "StartTime": "21:57",
        "ApproxVo2Max": "59.58"
    },
    {
        "AccumulatedShuttleDistance": "2800",
        "SpeedLevel": "21",
        "ShuttleNo": "3",
        "Speed": "18",
        "LevelTime": "8.0",
        "CommulativeTime": "22:32",
        "StartTime": "22:15",
        "ApproxVo2Max": "59.92"
    },
    {
        "AccumulatedShuttleDistance": "2840",
        "SpeedLevel": "21",
        "ShuttleNo": "4",
        "Speed": "18",
        "LevelTime": "8.0",
        "CommulativeTime": "22:50",
        "StartTime": "22:33",
        "ApproxVo2Max": "60.26"
    },
    {
        "AccumulatedShuttleDistance": "2880",
        "SpeedLevel": "21",
        "ShuttleNo": "5",
        "Speed": "18",
        "LevelTime": "8.0",
        "CommulativeTime": "23:08",
        "StartTime": "22:51",
        "ApproxVo2Max": "60.59"
    },
    {
        "AccumulatedShuttleDistance": "2920",
        "SpeedLevel": "21",
        "ShuttleNo": "6",
        "Speed": "18",
        "LevelTime": "8.0",
        "CommulativeTime": "23:26",
        "StartTime": "23:09",
        "ApproxVo2Max": "60.93"
    },
    {
        "AccumulatedShuttleDistance": "2960",
        "SpeedLevel": "21",
        "ShuttleNo": "7",
        "Speed": "18",
        "LevelTime": "8.0",
        "CommulativeTime": "23:44",
        "StartTime": "23:27",
        "ApproxVo2Max": "61.26"
    },
    {
        "AccumulatedShuttleDistance": "3000",
        "SpeedLevel": "21",
        "ShuttleNo": "8",
        "Speed": "18",
        "LevelTime": "8.0",
        "CommulativeTime": "24:02",
        "StartTime": "23:45",
        "ApproxVo2Max": "61.60"
    },
    {
        "AccumulatedShuttleDistance": "3040",
        "SpeedLevel": "22",
        "ShuttleNo": "1",
        "Speed": "18.5",
        "LevelTime": "7.8",
        "CommulativeTime": "24:19",
        "StartTime": "24:03",
        "ApproxVo2Max": "61.94"
    },
    {
        "AccumulatedShuttleDistance": "3080",
        "SpeedLevel": "22",
        "ShuttleNo": "2",
        "Speed": "18.5",
        "LevelTime": "7.8",
        "CommulativeTime": "24:37",
        "StartTime": "24:20",
        "ApproxVo2Max": "62.27"
    },
    {
        "AccumulatedShuttleDistance": "3120",
        "SpeedLevel": "22",
        "ShuttleNo": "3",
        "Speed": "18.5",
        "LevelTime": "7.8",
        "CommulativeTime": "24:55",
        "StartTime": "24:38",
        "ApproxVo2Max": "62.61"
    },
    {
        "AccumulatedShuttleDistance": "3160",
        "SpeedLevel": "22",
        "ShuttleNo": "4",
        "Speed": "18.5",
        "LevelTime": "7.8",
        "CommulativeTime": "25:13",
        "StartTime": "24:56",
        "ApproxVo2Max": "62.94"
    },
    {
        "AccumulatedShuttleDistance": "3200",
        "SpeedLevel": "22",
        "ShuttleNo": "5",
        "Speed": "18.5",
        "LevelTime": "7.8",
        "CommulativeTime": "25:31",
        "StartTime": "25:14",
        "ApproxVo2Max": "63.28"
    },
    {
        "AccumulatedShuttleDistance": "3240",
        "SpeedLevel": "22",
        "ShuttleNo": "6",
        "Speed": "18.5",
        "LevelTime": "7.8",
        "CommulativeTime": "25:48",
        "StartTime": "25:32",
        "ApproxVo2Max": "63.62"
    },
    {
        "AccumulatedShuttleDistance": "3280",
        "SpeedLevel": "22",
        "ShuttleNo": "7",
        "Speed": "18.5",
        "LevelTime": "7.8",
        "CommulativeTime": "26:06",
        "StartTime": "25:49",
        "ApproxVo2Max": "63.95"
    },
    {
        "AccumulatedShuttleDistance": "3320",
        "SpeedLevel": "22",
        "ShuttleNo": "8",
        "Speed": "18.5",
        "LevelTime": "7.8",
        "CommulativeTime": "26:24",
        "StartTime": "26:07",
        "ApproxVo2Max": "64.29"
    },
    {
        "AccumulatedShuttleDistance": "3360",
        "SpeedLevel": "23",
        "ShuttleNo": "1",
        "Speed": "19",
        "LevelTime": "7.6",
        "CommulativeTime": "26:42",
        "StartTime": "26:25",
        "ApproxVo2Max": "64.62"
    },
    {
        "AccumulatedShuttleDistance": "3400",
        "SpeedLevel": "23",
        "ShuttleNo": "2",
        "Speed": "19",
        "LevelTime": "7.6",
        "CommulativeTime": "26:59",
        "StartTime": "26:43",
        "ApproxVo2Max": "64.96"
    },
    {
        "AccumulatedShuttleDistance": "3440",
        "SpeedLevel": "23",
        "ShuttleNo": "3",
        "Speed": "19",
        "LevelTime": "7.6",
        "CommulativeTime": "27:17",
        "StartTime": "27:00",
        "ApproxVo2Max": "65.30"
    },
    {
        "AccumulatedShuttleDistance": "3480",
        "SpeedLevel": "23",
        "ShuttleNo": "4",
        "Speed": "19",
        "LevelTime": "7.6",
        "CommulativeTime": "27:34",
        "StartTime": "27:18",
        "ApproxVo2Max": "65.63"
    },
    {
        "AccumulatedShuttleDistance": "3520",
        "SpeedLevel": "23",
        "ShuttleNo": "5",
        "Speed": "19",
        "LevelTime": "7.6",
        "CommulativeTime": "27:52",
        "StartTime": "27:35",
        "ApproxVo2Max": "65.97"
    },
    {
        "AccumulatedShuttleDistance": "3560",
        "SpeedLevel": "23",
        "ShuttleNo": "6",
        "Speed": "19",
        "LevelTime": "7.6",
        "CommulativeTime": "28:09",
        "StartTime": "27:53",
        "ApproxVo2Max": "66.30"
    },
    {
        "AccumulatedShuttleDistance": "3600",
        "SpeedLevel": "23",
        "ShuttleNo": "7",
        "Speed": "19",
        "LevelTime": "7.6",
        "CommulativeTime": "28:27",
        "StartTime": "28:10",
        "ApproxVo2Max": "66.64"
    },
    {
        "AccumulatedShuttleDistance": "3640",
        "SpeedLevel": "23",
        "ShuttleNo": "8",
        "Speed": "19",
        "LevelTime": "7.6",
        "CommulativeTime": "28:45",
        "StartTime": "28:28",
        "ApproxVo2Max": "66.98"
    }
];

const userList = [
        {
        "PersonID": "1",
        "FitnessTestID": "1",
            "Name": "Charvik Jai ",
            "IsWarned": false,
            "IsStopped": false,
            "IsCompleted": false,
            "IsStarted": false,
            "AccumulatedShuttleDistance": "0",
            "SpeedLevel": "0",
            "ShuttleNo": "0",
            "Speed": "0",
            "LevelTime": "0",
            "CommulativeTime": "0",
            "StartTime": "0",
            "ApproxVo2Max": "0"
        },
        {
            "PersonID": "2",
            "FitnessTestID": "2",
            "Name": "Jai ",
            "IsWarned": false,
            "IsStopped": false,
            "IsCompleted": false,
            "IsStarted": false,
            "AccumulatedShuttleDistance": "0",
            "SpeedLevel": "0",
            "ShuttleNo": "0",
            "Speed": "0",
            "LevelTime": "0",
            "CommulativeTime": "0",
            "StartTime": "0",
            "ApproxVo2Max": "0"
        },
        {
            "PersonID": "3",
            "FitnessTestID": "3",
            "Name": "Charvik Jai ",
            "IsWarned": false,
            "IsStopped": false,
            "IsCompleted": true,
            "IsStarted": false,
            "AccumulatedShuttleDistance": "3640",
            "SpeedLevel": "23",
            "ShuttleNo": "8",
            "Speed": "19",
            "LevelTime": "7.6",
            "CommulativeTime": "28:45",
            "StartTime": "28:28",
            "ApproxVo2Max": "66.98"
        },
        {
            "PersonID": "4",
            "FitnessTestID": "4",
            "Name": "Seenu Eng",
            "IsWarned": false,
            "IsStopped": false,
            "IsCompleted": true,
            "IsStarted": false,
            "AccumulatedShuttleDistance": "3600",
            "SpeedLevel": "23",
            "ShuttleNo": "7",
            "Speed": "19",
            "LevelTime": "7.6",
            "CommulativeTime": "28:27",
            "StartTime": "28:10",
            "ApproxVo2Max": "66.64"
    }

];

var status = 'Play';


// Load all the users list
function loadAll() {

    var userListdata = [];
    
    $.ajax({
        type: 'GET',
        url: 'http://localhost:56648/api/YoyoTest',
        async: false,
        success: function (data) {
            userListdata = data;
            console.log('test data' + userListdata);
        },
        error: function (ex) {
            console.log('error on method : loadAll() ' + ex);
        }
    });

    if (userListdata != null && userListdata != undefined) {

        var trackerlist = $("#trackerList1");
        $("#aStart").removeClass();
        $("#aStart").addClass("show");
        $("#aStop").removeClass();
        $("#aStop").addClass("hide");
        $.each(userListdata, function (i, val) {
            console.log(val);
            var idli = "<input type='button' name='save' value='Save' class='btn btn-green margin-T20' id='res-tgListName-Btn-JS' onclick='onSaveTargetList(\"" + val.FitnessTestID + ",\"" + val.PersonID + "\");'>";
            var liID = "li" + val.PersonID;
            var libtnWarnID = "btnWan" + val.PersonID;
            var libtnStopID = "btnStop" + val.PersonID;
            var li = "<li id='" + liID + "'></li>";
            var liContent = '';
            if (!val.isStarted && !val.IsCompleted && !val.IsWarned) {
                liContent = "<li id='" + liID + "'><div><span>" + val.Name + "</span><span class='tracker-status-btn'><button type='button' id='" + libtnWarnID + "' class='btn btn-primary active' onclick='OnWarn(" + val.FitnessTestID + "," + val.PersonID + ");'>Warn </button> <button type='button' id='" + libtnStopID + "' class='btn btn-danger' onclick='OnStopped(" + val.FitnessTestID + "," + val.PersonID + ");' >Stop</button></span></div> </li>";
            }
            if (!val.isStarted && !val.IsCompleted && val.IsWarned) {
                liContent = "<li id='" + liID + "'><div><span>" + val.Name + "</span><span class='tracker-status-btn'><button type='button' id='" + libtnWarnID + "' class='btn btn-primary active' onclick='OnWarn(" + val.FitnessTestID + "," + val.PersonID + ");'>Warned </button> <button type='button' id='" + libtnStopID + "' class='btn btn-danger' onclick='OnStopped(" + val.FitnessTestID + "," + val.PersonID + ");' >Stop</button></span></div> </li>";
            }
            if (!val.isStarted && val.IsCompleted) {
                liContent = "<li id='" + liID + "'><div><span>" + val.Name + "</span><div class='tracker-status-val'> <span>" + val.ShuttleNo + "-" + val.SpeedLevel + " </span> <span class='glyphicon glyphicon-chevron-down'></div></div> </li>";
            }
            trackerlist.append(liContent);
        });
    }

}

function OnClickWarning(person,btnWarn, btnStop) {
    console.log(person);
}

function OnStart(fitnessID, Personid) {    
  //  console.log(person);
    var libtnStopID = "btnStop" + Personid;
    //var person = userList.filter(x => x.FitnessTestID == fitnessID && x.PersonID == Personid);

    //var person = userList.filter(function (x) {
    //    if (x.FitnessTestID == fitnessID && x.PersonID == Personid) {
    //        x.IsStarted = true;
    //        return x;
    //    }
    //    return null;
    //});
}

function FitnessTestStart(fitnessID, Personid) {
    $("#aStop").removeClass();
    $("#aStop").addClass("show");
    $("#aStart").removeClass();
    $("#aStart").addClass("hide");
  
}

function FitnessTestStop(fitnessID, Personid) {
    $("#aStop").removeClass();
    $("#aStop").addClass("hide");
    $("#aStart").removeClass();
    $("#aStart").addClass("show");
}

function OnStopped(fitnessID, Personid) {
    console.log(person);
    var libtnStopID = "btnStop" + val.PersonID;
    var person = userList.filter(x => x.FitnessTestID == fitnessID && x.PersonID == Personid);

    var person = userList.filter(function (x) {
        if (x.FitnessTestID == fitnessID && x.PersonID == Personid) {
            x.IsStopped = true;
            return x;
        }
        return null;
    });

}

// Onwarn click
function OnWarn(fitnessID, Personid) {
    var libtnWarnID = "#btnWan" + Personid;
    var person = userList.filter(x => x.FitnessTestID == fitnessID && x.PersonID == Personid); 

    var person = userList.filter(function (x) {
        if (x.FitnessTestID == fitnessID && x.PersonID == Personid) {
            x.IsWarned = true;
            return x;
        }
        return null;
    });
            
       
    //if (person != undefined && person != null) {
    //    var indexNumof = userList.indexOf(person);
    //    person.IsWarned = true;
    //    userList.splice(indexNumof, 1, person);
    //}
    

    console.log(userList);

    $(libtnWarnID).html('Warned');
    $(libtnWarnID).addClass('disabled click-off');

    var ApiWarnUrl = API_BASE_URL + 'Yoyo';

    //var PersonName = 'Test';
    //var params = {
    //    name: PersonName
    //};
    //$.ajax({
    //    type: 'POST',
    //    url: '/Yoyo/onwarn',
    //    async: false,
    //    data: params,
    //    success: function (data) {

    //    },
    //    error: function (ex) {
    //        console.log('error on method : OnWarn() ' + ex);
    //    }
    //});

}